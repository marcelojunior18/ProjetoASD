using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.Service
{
    public interface IFornecedorService
    {
        void AdicionaFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
    }
}
