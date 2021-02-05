using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services.Abstraction
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> pRepositoryBase)
        {
            this._repositoryBase = pRepositoryBase;
        }

        public async Task Adicionar(T pObj)
        {
            await this._repositoryBase.Adicionar(pObj);
        }

        public async Task Adicionar(IEnumerable<T> pLstObj)
        {
            await this._repositoryBase.Adicionar(pLstObj);
        }

        public async Task Editar(T pObj)
        {
            await this._repositoryBase.Editar(pObj);
        }

        public async Task Excluir(int pId)
        {
            await this._repositoryBase.Excluir(pId);
        }

        public async Task<T> Listar(int pId)
        {
            return await this._repositoryBase.Listar(pId);
        }

        public async Task<IEnumerable<T>> Listar()
        {
            return await this._repositoryBase.Listar();
        }
    }
}
