using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
         public DateTime? DataExclusao { get; set; }
    }
}
