using System;
using System.Net.Http;
using System.ServiceModel;
using Newtonsoft.Json;

namespace MovieService
{
    public class HttpClientRequest<T>
    {

        public T GetRequest(Uri uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(uri).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new FaultException(new FaultReason("Cannot Return any Data at this time due to error:" + response.ReasonPhrase));

            }

            var result = response.Content.ReadAsStringAsync().Result;
            var objectOuput = JsonConvert.DeserializeObject<T>(result);

            return objectOuput;
        }
    }
}
