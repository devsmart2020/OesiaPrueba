using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Interfaces
{
    public interface IGenericService<T>
    {
        Task<T> Create(T entity, bool isNewItem, string webApi);
        Task<T> Delete(string webApi);
        Task<IEnumerable<T>> GetAll(string webApi);
        Task<T> GetById(string webApi);
    }
}
