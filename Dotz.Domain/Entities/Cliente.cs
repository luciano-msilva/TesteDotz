
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string Celular { get; set; }
        public virtual IEnumerable<ClienteEndereco> ClienteEndereco { get; set; }
        public virtual IEnumerable<ClienteMovimentacao> ClienteMovimentacao { get; set; }
        public virtual IEnumerable<ClienteResgate> ClienteResgate { get; set; }
        public virtual IEnumerable<ClientePedido> ClientePedido { get; set; }
    }
}
