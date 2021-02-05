using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Application.Interfaces
{
    public interface IClientePedidoAppService:IAppServiceBase<ClientePedido>
    {
        Task<List<ClientePedido>> ObterPorCliente(int pCodigoCliente);
    }
}
