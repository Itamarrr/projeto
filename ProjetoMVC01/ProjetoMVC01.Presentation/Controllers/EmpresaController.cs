using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC01.Domain.Entities;
using ProjetoMVC01.Presentation.Models;
using ProjetoMVC01.Repository.Repositories;

namespace ProjetoMVC01.Presentation.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //recebe campos enviados por um formulário
        public IActionResult Cadastro(EmpresaCadastroViewModel model, 
            [FromServices] EmpresaRepository empresaRepository)
        {
            //verificar se todos os campos da model passaram
            //nas regras de validação..
            if(ModelState.IsValid)
            {
                try
                {
                    //verificar se ja existe uma empresa cadastrada com o CNPJ informado..
                    if(empresaRepository.ObterPorCnpj(model.Cnpj) != null)
                    {
                        //redireciona o fluxo de execução para o primeiro bloco catch
                        throw new Exception("O CNPJ informado já encontra-se cadastrado.");
                    }

                    var empresa = new Empresa();

                    empresa.IdEmpresa = Guid.NewGuid();
                    empresa.RazaoSocial = model.RazaoSocial;
                    empresa.Cnpj = model.Cnpj;

                    //gravando no banco de dados
                    empresaRepository.Inserir(empresa);

                    TempData["MensagemSucesso"] = $"Empresa {empresa.RazaoSocial}, cadastrado com sucesso.";
                    ModelState.Clear(); //limpa todos os campos da model (formulário)
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
                }
            }

            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        /*
         * Método para receber o SUBMIT POST da página de consulta
         * executado quando o botão SUBMIT for pressionado..
         */ 
        [HttpPost] //recebe os dados enviados pelo formulário
        public IActionResult Consulta(EmpresaConsultaViewModel model,
            [FromServices] EmpresaRepository empresaRepository)
        {
            //verificar se todos os campos da model
            //passaram nas regras de validação
            if(ModelState.IsValid)
            {
                try
                {
                    //realizando a consulta de empresas por razaosocial
                    model.Empresas = empresaRepository.ObterPorRazaoSocial(model.RazaoSocial);

                    //verificar se nenhum registro foi encontrado
                    if(model.Empresas.Count == 0)
                    {
                        TempData["MensagemAlerta"] = "Nenhuma empresa foi encontrada.";
                    }
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
                }
            }

            //enviando o objeto 'model' de volta para a página..
            return View(model);
        }

        //Método para realizar a exclusão da empresa..
        //URL: /Empresa/Exclusao?id=?
        public IActionResult Exclusao(Guid id,
            [FromServices] EmpresaRepository empresaRepository)
        {
            try
            {
                // verificar se a empresa possui funcionario 

                if (empresaRepository.ObterQuntidadeFuncionarios(id) > 0)
                {
                    throw new Exception("Não é permitido Excluir a empresa, Pois ela possui Funcionarios");
                }


                //buscar no banco de dados a empresa baseado no id..
                var empresa = empresaRepository.ObterPorId(id);

                //excluindo a empresa..
                empresaRepository.Excluir(empresa);

                TempData["MensagemSucesso"] = $"Empresa {empresa.RazaoSocial}, excluída com sucesso.";
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = e.Message;
            }

            //redirecionando para a página de consulta
            return RedirectToAction("Consulta"); //Empresa/Consulta
        }

        //Método para abrir a página de edição de empresa..
        //URL: /Empresa/Edicao?id=?
        public IActionResult Edicao(Guid id, 
            [FromServices] EmpresaRepository empresaRepository)
        {
            //criando um objeto da classe EmpresaEdicaoViewModel
            var model = new EmpresaEdicaoViewModel();

            try
            {
                //buscando a empresa no banco de dados atraves do id..
                var empresa = empresaRepository.ObterPorId(id);

                //transferindo os dados do objeto empresa para o objeto model..
                model.IdEmpresa = empresa.IdEmpresa;
                model.RazaoSocial = empresa.RazaoSocial;
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = e.Message;
            }

            //enviando o objeto model para a página..
            return View(model);
        }

        /*
         * Método HttpPost para receber o SUBMIT da página de edição de empresa
         */
        [HttpPost] //método que recebe a ação SUBMIT..
        public IActionResult Edicao(EmpresaEdicaoViewModel model,
            [FromServices] EmpresaRepository empresaRepository)
        {
            //verificando se todos os campos da model
            //passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    var empresa = new Empresa();
                    empresa.IdEmpresa = model.IdEmpresa;
                    empresa.RazaoSocial = model.RazaoSocial;

                    empresaRepository.Alterar(empresa);

                    TempData["MensagemSucesso"] = $"Empresa {empresa.RazaoSocial}, atualizada com sucesso.";
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            return View();
        }

    }
}
