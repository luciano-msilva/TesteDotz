using Dotz.Domain.Interface.Repositories;
using Dotz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public readonly Contexto _db;
        public RepositoryBase(Contexto pDb)
        {
            _db = pDb;
        }
        public async Task Adicionar(T pObj)
        {
            _db.Set<T>().Add(pObj);
            await _db.SaveChangesAsync();
        }

        public async Task Adicionar(IEnumerable<T> pLstObj)
        {
            _db.Set<T>().AddRange(pLstObj);
            await _db.SaveChangesAsync();
        }

        public async Task Editar(T pObj)
        {
            _db.Set<T>().Update(pObj);
            await _db.SaveChangesAsync();
        }

        public async Task Excluir(int pId)
        {
            var obj = _db.Set<T>().Find(pId);
            obj.GetType().GetProperty("DataExclusao").SetValue(obj, DateTime.Now);
            await _db.SaveChangesAsync();
        }

        public async Task<T> Listar(int pId)
        {
            var lst = await _db.Set<T>().FindAsync(pId);
            return lst;
        }

        public async Task<IEnumerable<T>> Listar()
        {
            var lst =  _db.Set<T>().ToList();
            return lst;
        }
    }
}
