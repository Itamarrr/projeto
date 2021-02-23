using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //validações
using ProjetoMVC01.Domain.DTOs;

namespace ProjetoMVC01.Presentation.Models
{
    public class FuncionarioConsultaViewModel
    {
        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public string DataInicioAdmissao { get; set; }
        public string DataFimAdmissao { get; set; }

        //propriedade que irá exibir os dados da consulta na página..
        public List<ConsultaFuncionarioDTO> Funcionarios { get; set; }

        public bool IsValid() //método para verificar se pelo menos 1 campo foi preenchido
        {
            return !string.IsNullOrEmpty(Nome)
                || !string.IsNullOrEmpty(Cpf)
                || !string.IsNullOrEmpty(Matricula)
                || !string.IsNullOrEmpty(DataInicioAdmissao)
                || !string.IsNullOrEmpty(DataFimAdmissao);
        }
    }
}
