using AutoMapper;
using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
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
    public class ClienteResgateController : absMainController
    {
        private readonly IClienteResgateAppService _clienteResgateAppService;
        private readonly IMapper _mapper;
        public ClienteResgateController(INotificador pNotificador, IClienteResgateAppService clienteResgateAppService, IMapper mapper) : base(pNotificador)
        {
            this._clienteResgateAppService = clienteResgateAppService;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteResgateViewModel>>> Get()
        {
            var resp = this._mapper.Map<List<ClienteResgateViewModel>>(await this._clienteResgateAppService.Listar());
            return CustomResponse(resp);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteResgateViewModel>> Get(int id)
        {
            var resp = this._mapper.Map<ClienteResgateViewModel>(await this._clienteResgateAppService.Listar(id));
            return CustomResponse(resp);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClienteResgateViewModel pObjClienteResgate)
        {
            await this._clienteResgateAppService.Adicionar(this._mapper.Map<ClienteResgate>(pObjClienteResgate));
            return CustomResponse(true);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClienteResgateViewModel pObjClienteEndereco)
        {
            if (id != pObjClienteEndereco.Codigo)
            {
                NotificarErro("Código no objeto encontra-se incorreto");
                return CustomResponse();
            }
            if (!ModelState.IsValid)
                return CustomResponse();

            await this._clienteResgateAppService.Editar(this._mapper.Map<ClienteResgate>(pObjClienteEndereco));
            return CustomResponse(true);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await this._clienteResgateAppService.Excluir(id);
            return CustomResponse();
        }
    }
}
