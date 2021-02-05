using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class ClienteMovimentacao:EntityBase
    {
        public int CodigoCliente { get; set; }
        public ETipoMovimentacao TipoMovimentacao { get; set; }
        public int QtdePontosUtilizados { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
