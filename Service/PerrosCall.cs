using KevinRosero_ExamenFinal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KevinRosero_ExamenFinal.Service
{
    public class PerrosCall
    {
        public async Task<PerroAPI> GetPerros()
        {
            PerroAPI resp = new PerroAPI();

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://dog.ceo/api/breeds/image/random");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");

            var client = new HttpClient();

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                resp = JsonConvert.DeserializeObject<PerroAPI>(content);
                return resp;
            }
            else
            {
                return null;
            }
        }
    }
}
