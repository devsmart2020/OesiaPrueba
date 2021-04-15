using Oesia.Front.Data.Base;
using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Services
{
    public class AuthorService : IAuthorService
    {
        #region Members Variables
        private readonly string webApi = "api/Authors";

        #endregion        

        #region PublicMethods
        public async Task<bool> CreateAuthor(AuthorDTO author, bool isNewItem)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<bool> restService = new RestService<bool>(baseUrl))
            {
                if (isNewItem)
                    return await restService.POSTAsync(webApi, author, false);
                else
                    return await restService.POSTAsync(webApi, author, true);
            }

        }

        public async Task<bool> DeleteAuthor(int id)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<bool> restService = new RestService<bool>(baseUrl))
            {
                return await restService.DELETEAsync(webApi);
            }
        }

        public async Task<IEnumerable<AuthorListDTO>> GetAllAuthors()
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<IEnumerable<AuthorListDTO>> restService = new RestService<IEnumerable<AuthorListDTO>>(baseUrl))
            {
                return await restService.GETAsync(webApi);
            }
        }

        public async Task<AuthorDTO> GetByIdAuthor(int id)
        {
            string baseUrl = BaseRestService.GetConnectionStringByName(false);
            using (RestService<AuthorDTO> restService = new RestService<AuthorDTO>(baseUrl))
            {
                return await restService.POSTAsync($"{webApi}{id}", null, false);
            }
        }

        #endregion
    }
}
