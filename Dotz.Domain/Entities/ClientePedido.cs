using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class ClientePedido:EntityBase
    {
        public int CodigoCliente { get; set; }
        public int CodigoClienteResgate { get; set; }
        public int CodigoClienteEndereco { get; set; }
        public EStatusEntrega EstatusEntrega { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ClienteResgate ClienteResgate { get; set; }
        public virtual ClienteEndereco ClienteEndereco { get; set; }
    }
}
