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
    public class ProdutoController : absMainController
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly IMapper _mapper;
        public ProdutoController(INotificador pNotificador, IMapper mapper, IProdutoAppService produtoAppService) : base(pNotificador)
        {
            this._produtoAppService = produtoAppService;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoViewModel>>> Get()
        {
            var resp = this._mapper.Map<List<ProdutoViewModel>>(await this._produtoAppService.Listar());
            return CustomResponse(resp);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoViewModel>> Get(int id)
        {
            var resp = this._mapper.Map<ProdutoViewModel>(await this._produtoAppService.Listar(id));
            return CustomResponse(resp);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProdutoViewModel pObjClienteResgate)
        {
            await this._produtoAppService.Adicionar(this._mapper.Map<Produto>(pObjClienteResgate));
            return CustomResponse(true);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProdutoViewModel pObjClienteEndereco)
        {
            if (id != pObjClienteEndereco.Codigo)
            {
                NotificarErro("Código no objeto encontra-se incorreto");
                return CustomResponse();
            }
            if (!ModelState.IsValid)
                return CustomResponse();

            await this._produtoAppService.Editar(this._mapper.Map<Produto>(pObjClienteEndereco));
            return CustomResponse(true);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await this._produtoAppService.Excluir(id);
            return CustomResponse();
        }
    }
}
