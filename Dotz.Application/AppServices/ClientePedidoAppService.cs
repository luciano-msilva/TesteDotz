using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Application.AppServices
{
    public class ClientePedidoAppService : AppServiceBase<ClientePedido>, IClientePedidoAppService
    {
        private readonly IClientePedidoService _clientePedidoService;
        public ClientePedidoAppService(IClientePedidoService clientePedidoService) : base(clientePedidoService)
        {
            this._clientePedidoService = clientePedidoService;
        }

        public async Task<List<ClientePedido>> ObterPorCliente(int pCodigoCliente)
        {
            return await this._clientePedidoService.ObterPorCliente(pCodigoCliente);
        }
    }
}
