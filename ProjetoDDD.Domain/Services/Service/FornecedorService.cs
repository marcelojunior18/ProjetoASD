using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;

namespace ProjetoDDD.Domain.Services.Service
{
    public class FornecedorService : IFornecedorService
    {

        private IFornecedorRepository repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            this.repository = repository;
        }

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            this.repository.AdicionaFornecedor(fornecedor);
        }

        public List<Fornecedor> ObtemTodos()
        {
            return this.repository.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return repository.ObterFornecedor(id);
        }
    }
}
