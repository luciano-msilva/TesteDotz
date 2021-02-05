using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Interface.Repositories
{
    public interface IClientePedidoRepository:IRepositoryBase<ClientePedido>
    {
        Task<List<ClientePedido>> ObterPorCliente(int pCodigoCliente);
    }
}
