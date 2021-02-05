using Dotz.Domain.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Interface.Extensions
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
