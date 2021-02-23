using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoMVC01.Domain.DTOs;
using ProjetoMVC01.Domain.Entities;
using ProjetoMVC01.Presentation.Models;
using ProjetoMVC01.Repository.Repositories;

namespace ProjetoMVC01.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        //método executado quando a página de cadastro é aberta..
        public IActionResult Cadastro([FromServices] EmpresaRepository empresaRepository)
        {
            var model = new FuncionarioCadastroViewModel();
            model.ListagemDeEmpresas = ObterEmpresas(empresaRepository.ObterTodos());

            return View(model);
        }

        [HttpPost] //executado após o evento SUBMIT do formulário
        public IActionResult Cadastro(FuncionarioCadastroViewModel model,
            [FromServices] EmpresaRepository empresaRepository,
            [FromServices] FuncionarioRepository funcionarioRepository)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    //verificar se o cpf informado já está cadastrado.
                    if(funcionarioRepository.ObterPorCpf(model.Cpf) != null)
                    {
                        throw new Exception("O Cpf informado já encontra-se cadastrado.");
                    }

                    //verificar se a matricula informada já está cadastrada
                    if(funcionarioRepository.ObterPorMatricula(model.Matricula) != null)
                    {
                        throw new Exception("A Matrícula informada já encontra-se cadastrada.");
                    }

                    //cadastrando o funcionário no banco de dados..
                    var funcionario = new Funcionario();

                    funcionario.IdFuncionario = Guid.NewGuid();
                    funcionario.Nome = model.Nome;
                    funcionario.Cpf = model.Cpf;
                    funcionario.Matricula = model.Matricula;
                    funcionario.DataAdmissao = DateTime.Parse(model.DataAdmissao);
                    funcionario.IdEmpresa = Guid.Parse(model.IdEmpresa);

                    funcionarioRepository.Inserir(funcionario); //gravando no banco de dados

                    TempData["MensagemSucesso"] = $"Funcionário {funcionario.Nome}, cadastrado com sucesso.";
                    ModelState.Clear(); //limpa os campos do formulário
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            model.ListagemDeEmpresas = ObterEmpresas(empresaRepository.ObterTodos());
            return View(model);
        }

        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost] //executado a partir do SUBMIT do formulário
        public IActionResult Consulta(FuncionarioConsultaViewModel model, 
            [FromServices] FuncionarioRepository funcionarioRepository)
        {
            if(ModelState.IsValid)
            {
                try
                {                    
                    if (!model.IsValid())
                        throw new Exception("Informe pelo menos 1 dos filtros solicitados.");
                                        
                    var dto = new FiltroFuncionarioDTO();

                    dto.Nome = model.Nome;
                    dto.Cpf = model.Cpf;
                    dto.Matricula = model.Matricula;
                    dto.DataInicioAdmissao = !string.IsNullOrEmpty(model.DataInicioAdmissao)
                        ? DateTime.Parse(model.DataInicioAdmissao) : DateTime.MinValue;
                    dto.DataFimAdmissao = !string.IsNullOrEmpty(model.DataFimAdmissao)
                        ? DateTime.Parse(model.DataFimAdmissao) : DateTime.MinValue;

                    //executar a consulta no banco de dados..
                    model.Funcionarios = funcionarioRepository.Consultar(dto);

                    if (model.Funcionarios.Count == 0)
                    {
                        TempData["MensagemAlerta"] = "Nenhum funcionário foi encontrado.";
                    }
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            return View(model);
        }

        // método pra realizar a exclusão do funcionario
        // rota /Funcionario/Exclusao?id=...

        public IActionResult Exclusao(Guid id, 
            [FromServices] FuncionarioRepository funcionarioRepository)
        {
            try
            {
                // buscar o funcionario pelo id
                var funcionario = funcionarioRepository.ObterPorId(id);
                // excluir funcionario
                funcionarioRepository.Excluir(funcionario);

                TempData["MensagemSucesso"] = $"Funcionario {funcionario.Nome}, excluido com sucesso.";
            }
            catch (Exception e)
            {

                TempData["MensagemErro"] = e.Message;
            }


            // redirecionamanto em caso da exclusão não funcinar
            return RedirectToAction("Consulta");
        }

        public IActionResult Edicao(Guid id, 
            [FromServices] FuncionarioRepository funcionarioRepository,
            [FromServices] EmpresaRepository empresaRepository)
        {

            var model = new FuncionarioEdicaoVewModel();
            try
            {
                // buscar os dados do funcionario no banco  atravez do id
                var funcionario = funcionarioRepository.ObterPorId(id);


                // transferindo os dados do funcionario para model..
                model.IdFuncionario = funcionario.IdFuncionario;
                model.Nome = funcionario.Nome;
                model.DataAdmissao = funcionario.DataAdmissao.ToString("yyy-MM-dd");
                model.IdEmpresa = funcionario.IdEmpresa.ToString();
                model.ListagemDeEmpresas = ObterEmpresas(empresaRepository.ObterTodos());

            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }


            return View(model);


        }


        [HttpPost]
        public IActionResult Edicao(FuncionarioEdicaoVewModel model,
            [FromServices] FuncionarioRepository funcionarioRepository,
            [FromServices] EmpresaRepository empresaRepository)
        {

            // verificar se os campos estão validados corretamente 

            if (ModelState.IsValid)
            {
                try
                {
                    // buscar os dados no funcionario no banco 
                    var funcionario = funcionarioRepository.ObterPorId(model.IdFuncionario);

                    // modificar os dados dele...
                    funcionario.Nome = model.Nome;
                    funcionario.DataAdmissao = DateTime.Parse(model.DataAdmissao);
                    funcionario.IdEmpresa = Guid.Parse(model.IdEmpresa);

                    funcionarioRepository.Alterar(funcionario);

                    TempData["MensagemSucesso"] = "Funcionario Atualizado Com Sucesso";

                }
                catch (Exception e)
                {
                    TempData["MenssagemErro"] = e.Message;
                }
            }

            model.ListagemDeEmpresas = ObterEmpresas(empresaRepository.ObterTodos());
            return View(model);
        }


        #region Carregamento dos campos DropDownList

        private List<SelectListItem> ObterEmpresas(List<Empresa> empresas)
        {
            //lista de itens de seleção (DropDownList)
            var lista = new List<SelectListItem>();

            //percorrer as empresas recebidas
            foreach (var item in empresas)
            {
                var selectListItem = new SelectListItem();
                selectListItem.Value = item.IdEmpresa.ToString();
                selectListItem.Text = $"{item.RazaoSocial.ToUpper()} ({item.Cnpj})";

                lista.Add(selectListItem);
            }

            return lista;
        }

        #endregion
    }
}
