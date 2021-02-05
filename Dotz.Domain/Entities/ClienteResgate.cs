using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class ClienteResgate:EntityBase
    {
        public int CodigoCliente { get; set; }
        public int CodigoProduto { get; set; }
        public int CodigoParceiro { get; set; }
        public int QtdeProduto { get; set; }
        public int QtdePontosUtilizados { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public virtual List<ClientePedido> ClientePedido { get; set; }
    }
}
