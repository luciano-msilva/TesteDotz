using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services
{
    public class ClienteResgateService : ServiceBase<ClienteResgate>, IClienteResgateService
    {
        private readonly IClienteResgateRepository _clienteResgateRepository;
        private readonly IClienteMovimentacaoService _clienteMovimentacaoService;
        private readonly IClientePedidoRepository _clientePedidoRepository;
        public ClienteResgateService(IClienteResgateRepository pClienteResgateRepository, 
            IClienteMovimentacaoService clienteMovimentacaoService,
            IClientePedidoRepository clientePedidoRepository) : base(pClienteResgateRepository)
        {
            this._clienteResgateRepository = pClienteResgateRepository;
            this._clienteMovimentacaoService = clienteMovimentacaoService;
            this._clientePedidoRepository = clientePedidoRepository;
        }

        async Task IServiceBase<ClienteResgate>.Adicionar(ClienteResgate pObj)
        {
            var objClienteMoviementacao = new ClienteMovimentacao();            
            objClienteMoviementacao.TipoMovimentacao = ETipoMovimentacao.Debito;
            objClienteMoviementacao.QtdePontosUtilizados = pObj.QtdePontosUtilizados;
            objClienteMoviementacao.CodigoCliente = pObj.CodigoCliente;

            await this._clienteMovimentacaoService.Adicionar(objClienteMoviementacao);

            await this._clienteResgateRepository.Adicionar(pObj);
            var objPedido = new ClientePedido();
            objPedido.CodigoCliente = pObj.CodigoCliente;
            objPedido.CodigoClienteResgate = pObj.Codigo;
            objPedido.CodigoClienteEndereco = 1;
            objPedido.EstatusEntrega = EStatusEntrega.PreparandoEnvio;
            await this._clientePedidoRepository.Adicionar(objPedido);
            
        }
    }
}
