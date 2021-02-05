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
    public class ClienteEnderecoController : absMainController
    {
        private readonly IClienteEnderecoAppService _clienteEnderecoAppService;
        private readonly IMapper _mapper;
        public ClienteEnderecoController(INotificador pNotificador, IClienteEnderecoAppService clienteEnderecoAppService, IMapper mapper) : base(pNotificador)
        {
            this._clienteEnderecoAppService = clienteEnderecoAppService;
            this._mapper = mapper;
        }
                
        [HttpGet]
        public async Task<ActionResult<List<ClienteEnderecoViewModel>>> Get()
        {
            var resp = this._mapper.Map<List<ClienteEnderecoViewModel>>(await this._clienteEnderecoAppService.Listar());
            return CustomResponse(resp);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteEnderecoViewModel>> Get(int id)
        {
            var resp = this._mapper.Map<ClienteEnderecoViewModel>(await this._clienteEnderecoAppService.Listar(id));
            return CustomResponse(resp);
        }
                
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClienteEnderecoViewModel pObjClienteEndereco)
        {
            await this._clienteEnderecoAppService.Adicionar(this._mapper.Map<ClienteEndereco>(pObjClienteEndereco));
            return CustomResponse(true);
        }
                
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClienteEnderecoViewModel pObjClienteEndereco)
        {
            if (id != pObjClienteEndereco.Codigo)
            {
                NotificarErro("Código no objeto encontra-se incorreto");
                return CustomResponse();
            }
            if (!ModelState.IsValid)
                return CustomResponse();

            await this._clienteEnderecoAppService.Editar(this._mapper.Map<ClienteEndereco>(pObjClienteEndereco));
            return CustomResponse(true);
        }
                
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await this._clienteEnderecoAppService.Excluir(id);
            return CustomResponse();
        }
    }
}
