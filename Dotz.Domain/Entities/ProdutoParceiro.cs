using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class ProdutoParceiro:EntityBase
    {
        public int CodigoParceiro { get; set; }
        public int CodigoProduto { get; set; }
        public int QtdePontosNecessarios { get; set; }
        public int QtdeEmEstoqueDisponivel { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
