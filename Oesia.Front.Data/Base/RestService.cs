using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Oesia.Front.Data.Base
{
    public class RestService<T> : BaseRestService
    {
        #region Constructor
        public RestService(string baseUrl)
            : base(baseUrl)
        {
        }
        public RestService(string baseUrl, string token)
           : base(baseUrl, token)
        {
        }
        #endregion

        #region Private Methods
        public virtual async Task<T> GETAsync(string url)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            T result;

            response = await Client.GetAsync(url);
            result = await CastResponseAsync<T>(response);
            return result;

        }

        public virtual async Task<T> POSTAsync(string url, object postData, bool isUpdate)
        {
            T result;

            //Organizamos la petición
            object dataToParse = postData ?? string.Empty;
            string jsonString = JsonConvert.SerializeObject(dataToParse);
            StringContent postDataContent = new StringContent(jsonString, Encoding.UTF8, Resources.StringMediaType);

            //Realizamos la petición
            HttpResponseMessage response = new HttpResponseMessage();

            if (!isUpdate)
            {
                response = await Client.PostAsync(url, postDataContent);
                result = await CastResponseAsync<T>(response);
            }
            else
            {
                response = await Client.PutAsync(url, postDataContent);
                result = await CastResponseAsync<T>(response);
            }

            return result;
        }

        public virtual async Task<T> DELETEAsync(string url)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            T result;

            response = await Client.DeleteAsync(url);
            result = await CastResponseAsync<T>(response);
            return result;
        }        
        #endregion
    }
}
