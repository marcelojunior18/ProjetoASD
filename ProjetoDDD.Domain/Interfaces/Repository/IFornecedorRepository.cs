using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.Repository
{
    public interface IFornecedorRepository
    {
        void AdicionaFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
    }
}
