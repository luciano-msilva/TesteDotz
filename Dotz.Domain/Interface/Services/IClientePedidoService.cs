using Dotz.Domain.Entities;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Interface.Services
{
    public interface IClientePedidoService: IServiceBase<ClientePedido>
    {
        Task<List<ClientePedido>> ObterPorCliente(int pCodigoCliente);
    }
}
