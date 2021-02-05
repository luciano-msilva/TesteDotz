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
    public class ClienteMovimentacaoController : absMainController
    {
        private readonly IClienteMovimentacaoAppService _clienteMovimentacaoAppService;
        private readonly IMapper _mapper;
        public ClienteMovimentacaoController(INotificador pNotificador, IClienteMovimentacaoAppService clienteMovimentacaoAppService, IMapper mapper) : base(pNotificador)
        {
            this._clienteMovimentacaoAppService = clienteMovimentacaoAppService;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteMovimentacaoViewModel>>> Get()
        {
            var resp = this._mapper.Map<List<ClienteMovimentacaoViewModel>>(await this._clienteMovimentacaoAppService.Listar());
            return CustomResponse(resp);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteMovimentacaoViewModel>> Get(int id)
        {
            var resp = this._mapper.Map<ClienteMovimentacaoViewModel>(await this._clienteMovimentacaoAppService.Listar(id));
            return CustomResponse(resp);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClienteMovimentacaoViewModel pObjClienteEndereco)
        {
            await this._clienteMovimentacaoAppService.Adicionar(this._mapper.Map<ClienteMovimentacao>(pObjClienteEndereco));
            return CustomResponse(true);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClienteMovimentacaoViewModel pObjClienteEndereco)
        {
            if (id != pObjClienteEndereco.Codigo)
            {
                NotificarErro("Código no objeto encontra-se incorreto");
                return CustomResponse();
            }
            if (!ModelState.IsValid)
                return CustomResponse();

            await this._clienteMovimentacaoAppService.Editar(this._mapper.Map<ClienteMovimentacao>(pObjClienteEndereco));
            return CustomResponse(true);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await this._clienteMovimentacaoAppService.Excluir(id);
            return CustomResponse();
        }
    }
}
