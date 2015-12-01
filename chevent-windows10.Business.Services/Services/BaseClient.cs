using System.Net.Http;
using System.Threading.Tasks;

namespace chevent_windows10.Business.Services.Services
{
    public class BaseClient<T> 
    {
        protected const string baseURL = "http://eksiapi.azurewebsites.net";
        protected HttpClient client;

        public BaseClient()
        {
            client = new HttpClient();
        }

        public async Task<T> GetAsync(string prefix = null)
        {
            string url = baseURL;
            if (prefix != null)
            {
                url = baseURL + prefix;
            }
            using (var response = await client.GetAsync(url))
            {
                return await response.Content.ReadAsAsync<T>();
            }
        }
    }
}
