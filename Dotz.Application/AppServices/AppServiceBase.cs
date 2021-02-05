using Dotz.Application.Interfaces;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Application.AppServices
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> _serviceBase;

        public AppServiceBase(IServiceBase<T> pServiceBase)
        {
            this._serviceBase = pServiceBase;
        }

        public async Task Adicionar(T pObj)
        {
            await this._serviceBase.Adicionar(pObj);
        }

        public async Task Adicionar(IEnumerable<T> pLstObj)
        {
            await this._serviceBase.Adicionar(pLstObj);
        }

        public async Task Editar(T pObj)
        {
            await this._serviceBase.Adicionar(pObj);
        }

        public async Task Excluir(int pId)
        {
            await this._serviceBase.Excluir(pId);
        }

        public async Task<T> Listar(int pId)
        {
            return await this._serviceBase.Listar(pId);
        }

        public async Task<IEnumerable<T>> Listar()
        {
            return await this._serviceBase.Listar();
        }
    }
}
