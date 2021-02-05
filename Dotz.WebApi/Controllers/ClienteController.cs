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
    public class ClienteController : absMainController
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IMapper _mapper;
        public ClienteController(INotificador pNotificador, IClienteAppService pClienteAppService, IMapper mapper) : base(pNotificador)
        {
            this._clienteAppService = pClienteAppService;
            this._mapper = mapper;
        }
                
        [HttpGet]
        public async Task<ActionResult<List<ClienteViewModel>>> Get()
        {
            var resp = this._mapper.Map<List<ClienteViewModel>>(await this._clienteAppService.Listar());
            return CustomResponse(resp);
        }
                
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteViewModel>> Get(int id)
        {
            var resp = this._mapper.Map<ClienteViewModel>(await this._clienteAppService.Listar(id));
            return CustomResponse(resp);
        }

        
        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Cliente pObjCliente)
        {
            await this._clienteAppService.Adicionar(pObjCliente);
            return CustomResponse(true);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cliente pObjCliente)
        {
            if (id != pObjCliente.Codigo)
            {
                NotificarErro("Código no objeto encontra-se incorreto");
                return CustomResponse();
            }
            if (!ModelState.IsValid)
                return CustomResponse();

            await this._clienteAppService.Editar(pObjCliente);
            return CustomResponse(true);
        }
                
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await this._clienteAppService.Excluir(id);
            return CustomResponse();
        }
    }
}
