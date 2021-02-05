using Dotz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Models
{
    public class ProdutoViewModel
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public ECategoriaProduto ECategoriaProduto { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
