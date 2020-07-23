using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.DataAccess.Interfaces
{
    public interface IRepository<T> where T:class
    {
        Task<T> GetById(int id);
        Task<IList<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(int id, T studentDto);
        Task<T>  Remove(int id);
    }
}