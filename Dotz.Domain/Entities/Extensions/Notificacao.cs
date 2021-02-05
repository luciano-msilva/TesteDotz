using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities.Extensions
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }
    }
}
