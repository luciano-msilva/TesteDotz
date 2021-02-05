using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.AppServices
{
    public class ParceiroAppService : AppServiceBase<Parceiro>, IParceiroAppService
    {
        private readonly IParceiroService _parceiroAppService;

        public ParceiroAppService(IParceiroService parceiroAppService) : base(parceiroAppService)
        {
            _parceiroAppService = parceiroAppService;
        }
    }
}
