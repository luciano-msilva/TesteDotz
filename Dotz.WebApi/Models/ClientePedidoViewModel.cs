using Dotz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Models
{
    public class ClientePedidoViewModel
    {
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoClienteResgate { get; set; }
        public int CodigoClienteEndereco { get; set; }
        public EStatusEntrega EstatusEntrega { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
