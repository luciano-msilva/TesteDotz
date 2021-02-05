using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Services
{
    public class ParceiroService:ServiceBase<Parceiro>, IParceiroService
    {
        private readonly IParceiroRepository _parceiroRepository;

        public ParceiroService(IParceiroRepository parceiroRepository):base(parceiroRepository)
        {
            this._parceiroRepository = parceiroRepository;
        }
    }
}
