using ProjetoMVC01.Domain.DTOs;
using ProjetoMVC01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVC01.Repository.Interfaces
{
    public interface IFuncionarioRepository
        : IBaseRepository<Funcionario>
    {
        Funcionario ObterPorCpf(string cpf);
        Funcionario ObterPorMatricula(string matricula);

        List<ConsultaFuncionarioDTO> Consultar(FiltroFuncionarioDTO dto);
    }
}
