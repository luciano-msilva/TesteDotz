using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Interface.Services
{
    public interface IServiceBase<T> where T:class
    {
        Task Adicionar(T pObj);
        Task Adicionar(IEnumerable<T> pLstObj);
        Task<T> Listar(int pId);
        Task<IEnumerable<T>> Listar();
        Task Editar(T pObj);
        Task Excluir(int pId);
    }
}
