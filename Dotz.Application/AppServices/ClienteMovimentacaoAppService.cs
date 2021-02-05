using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.AppServices
{
    public class ClienteMovimentacaoAppService:AppServiceBase<ClienteMovimentacao>, IClienteMovimentacaoAppService
    {
        private readonly IClienteMovimentacaoService _clienteMovimentacaoService;

        public ClienteMovimentacaoAppService(IClienteMovimentacaoService clienteMovimentacaoService):base(clienteMovimentacaoService)
        {
            _clienteMovimentacaoService = clienteMovimentacaoService;
        }
    }
}
