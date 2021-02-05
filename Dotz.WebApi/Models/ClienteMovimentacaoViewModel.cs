using Dotz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Models
{
    public class ClienteMovimentacaoViewModel
    {
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public ETipoMovimentacao TipoMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
