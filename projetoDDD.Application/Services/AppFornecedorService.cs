using projetoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Service;

namespace projetoDDD.Application.Services
{
    public class AppFornecedorService : IAppFornecedorService
    {

        private IFornecedorService service;

        public AppFornecedorService(IFornecedorService service)
        {
            this.service = service;
        }

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            this.service.AdicionaFornecedor(fornecedor);
        }

        public List<Fornecedor> ObtemTodos()
        {
            return this.service.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return service.ObterFornecedor(id);
        }
    }
}
