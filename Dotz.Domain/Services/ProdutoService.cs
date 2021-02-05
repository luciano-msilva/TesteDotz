using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }
    }
}
