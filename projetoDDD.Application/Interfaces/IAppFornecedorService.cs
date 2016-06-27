using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppFornecedorService
    {
        void AdicionaFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
    }
}
