using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Models
{
    public class ClienteResgateViewModel
    {
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoProduto { get; set; }
        public int CodigoParceiro { get; set; }
        public int QtdeProduto { get; set; }
        public int QtdePontosUtilizados { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
