using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string Descricao { get; set; }
        public ECategoriaProduto ECategoriaProduto {get;set;}
        public virtual List<ClienteResgate> ClienteResgate { get; set; }
        public virtual IEnumerable<ProdutoParceiro> ProdutoParceiro { get; set; }
    }
}
