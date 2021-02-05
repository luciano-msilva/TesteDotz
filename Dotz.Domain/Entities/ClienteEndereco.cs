using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class ClienteEndereco:EntityBase
    {        
        public int CodigoCliente { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public bool EnderecoPrincipal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual List<ClientePedido> ClientePedido { get; set; }
    }
}
