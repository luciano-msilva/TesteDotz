using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Models
{
    public class ProdutoParceiroViewModel
    {
        public int Codigo { get; set; }
        public int CodParceiro { get; set; }
        public int CodigoProduto { get; set; }
        public int QtdePontosNecessarios { get; set; }
        public int QtdeEmEstoqueDisponivel { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
