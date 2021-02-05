using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services
{
    public class ClientePedidoService : ServiceBase<ClientePedido>, IClientePedidoService
    {
        private readonly IClientePedidoRepository _clientePedidoRepository;
        public ClientePedidoService(IClientePedidoRepository clientePedidoRepository) : base(clientePedidoRepository)
        {
            this._clientePedidoRepository = clientePedidoRepository;
        }

        public async Task<List<ClientePedido>> ObterPorCliente(int pCodigoCliente)
        {
            return await this._clientePedidoRepository.ObterPorCliente(pCodigoCliente);
        }
    }
}
