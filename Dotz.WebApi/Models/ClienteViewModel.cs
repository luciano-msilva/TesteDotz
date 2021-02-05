using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Models
{
    public class ClienteViewModel
    {
        public int Codigo { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string Celular { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
