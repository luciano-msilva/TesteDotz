using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Parceiro:EntityBase
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public virtual List<ClienteResgate> ClienteResgate { get; set; }
        public virtual List<ProdutoParceiro> ProdutoParceiro { get; set; }
    }
}
