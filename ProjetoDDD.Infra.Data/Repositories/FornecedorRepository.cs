using ProjetoDDD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Entity;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {

        private BancoDeDados bd = new BancoDeDados();
       

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            bd.Fornecedores.Add(fornecedor);
            bd.SaveChanges();
        }

        public List<Fornecedor> ObtemTodos()
        {
            return bd.Fornecedores.ToList();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return bd.Fornecedores.Find(id);
        }
    }
}
