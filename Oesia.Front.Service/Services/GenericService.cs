using Oesia.Front.Data.Base;
using Oesia.Front.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Services
{
    public class GenericService<T> : IGenericService<T>
    {
        public async Task<T> Create(T entity, bool isNewItem, string webApi)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<T> restService = new RestService<T>(baseUrl))
            {
                if (isNewItem)
                    return await restService.POSTAsync(webApi, entity, false);
                else
                    return await restService.POSTAsync(webApi, entity, true);
            }
        }

        public async Task<T> Delete(string webApi)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<T> restService = new RestService<T>(baseUrl))
            {
                return await restService.DELETEAsync(webApi);
            }
        }

        public async Task<IEnumerable<T>> GetAll(string webApi)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<IEnumerable<T>> restService = new RestService<IEnumerable<T>>(baseUrl))
            {
                return await restService.GETAsync(webApi);
            }
        }

        public async Task<T> GetById(string webApi)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<T> restService = new RestService<T>(baseUrl))
            {
                return await restService.POSTAsync(webApi, null, false);
            }
        }
    }
}
