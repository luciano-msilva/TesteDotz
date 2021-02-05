using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Infra.Data.Repositories
{
    public class ClientePedidoRepository : RepositoryBase<ClientePedido>, IClientePedidoRepository
    {
        public ClientePedidoRepository(Contexto pDb) : base(pDb)
        {
        }

        public async Task<List<ClientePedido>> ObterPorCliente(int pCodigoCliente)
        {
            var lstClientePedido = await _db.Set<ClientePedido>().Where(x => x.CodigoCliente == pCodigoCliente && !x.DataExclusao.HasValue).ToListAsync();
            return lstClientePedido;
        }
    }
}
