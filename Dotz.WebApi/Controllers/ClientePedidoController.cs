using AutoMapper;
using Dotz.Application.Interfaces;
using Dotz.Domain.Interface.Extensions;
using Dotz.WebApi.Abstraction;
using Dotz.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientePedidoController : absMainController
    {
        private readonly IClientePedidoAppService _clientePedidoAppService;
        private readonly IMapper _mapper;
        public ClientePedidoController(INotificador pNotificador, IClientePedidoAppService clientePedidoAppService, IMapper mapper) : base(pNotificador)
        {
            this._clientePedidoAppService = clientePedidoAppService;
            this._mapper = mapper;
        }

        // GET: api/<ClientePedidoController>
        [HttpGet("ObterPorCliente/{id}")]
        public async Task<ActionResult<IEnumerable<ClientePedidoViewModel>>> ObterPorCliente(int id)
        {
            var lstClientePedido = await this._clientePedidoAppService.ObterPorCliente(id);
            return CustomResponse(this._mapper.Map<IEnumerable<ClientePedidoViewModel>>(lstClientePedido));
        }

        
    }
}
