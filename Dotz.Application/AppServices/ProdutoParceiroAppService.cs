using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.AppServices
{
    public class ProdutoParceiroAppService : AppServiceBase<ProdutoParceiro>, IProdutoParceiroAppService
    {
        private readonly IProdutoParceiroService _produtoParceiroService;
        public ProdutoParceiroAppService(IServiceBase<ProdutoParceiro> pServiceBase) : base(pServiceBase)
        {
        }
    }
}
