using ProjetoMVC01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVC01.Repository.Interfaces
{
    public interface IEmpresaRepository
        : IBaseRepository<Empresa>
    {
        Empresa ObterPorCnpj(string cnpj);
        List<Empresa> ObterPorRazaoSocial(string razaoSocial);

        int ObterQuntidadeFuncionarios(Guid idEmpresa);
    }
}
