using Newtonsoft.Json;
using Oesia.App.Data;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Oesia.App.Data.Base
{
    public class BaseRestService : IDisposable
    {
        #region Private Members Variables
        protected HttpClient Client { get; private set; }
        protected string BaseUrl { get; private set; }
        #endregion

        #region Constructor
        public BaseRestService(string baseUrl)
        {
            BaseUrl = baseUrl;
            Client = CreateClient(null);
        }
        public BaseRestService(string baseUrl, string token)
        {
            BaseUrl = baseUrl;
            Client = CreateClient(token);
        }
        #endregion

        #region Public Methods
        private HttpClient CreateClient(string token)
        {
            var handler = new HttpClientHandler()
            {
                UseProxy = true,
                Proxy = WebRequest.DefaultWebProxy
            };

            Uri uri = new Uri(BaseUrl);
            var httpClient = new HttpClient(handler)
            {
                BaseAddress = uri
            };

            if (!string.IsNullOrEmpty(token))
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Resources.RequestHeaders));
            }
            else
            {
                httpClient.Timeout = TimeSpan.FromSeconds(30);
                httpClient.DefaultRequestHeaders.Accept.Clear();
            }
            return httpClient;
        }

        protected async Task<T> CastResponseAsync<T>(HttpResponseMessage response)
        {
            T result = default;
            //Revisamos si hay problemas en la respuesta y no es 200 en el HTTP
            if (response.IsSuccessStatusCode)
            {

                JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };

                var jsonString = await response.Content.ReadAsStringAsync();
                result = await Task.Run(() => JsonConvert.DeserializeObject<T>(jsonString));
            }
            else
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonString))
                {
                    ErrorRestService = JsonConvert.DeserializeObject(jsonString).ToString();
                }
            }

            return result;
        }


        public void Dispose()
        {
            Client.Dispose();
        }
        #endregion

        #region Static Methods
        public static string GetConnectionStringByName(bool isApiSecurity)
        {
            string returnValue = string.Empty;
            string settings;
            if (isApiSecurity)
            {
                settings = Config.BASE_URL_SECURITY;
            }
            else
            {
                settings = Config.BASE_URL;
            }

            if (settings != null)
            {
                returnValue = settings;
            }
            return returnValue;
        }
        #endregion

        public static string MsjRestService { get; set; }
        public static string ErrorRestService { get; set; }

    }
}
