using AutoMapper;
using Dotz.Domain.Interface.Extensions;
using Dotz.WebApi.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoParceiroController : absMainController
    {
        private readonly IProdutoParceiroAppService _produtoParceiroAppService;
        private readonly IMapper _mapper;
        public ProdutoParceiroController(INotificador pNotificador) : base(pNotificador)
        {
        }

        // GET: api/<ProdutoParceiroController>
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
