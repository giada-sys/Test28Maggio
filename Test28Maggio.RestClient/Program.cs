using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Test28Maggio.Library;

namespace Test28Maggio.RESTClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ///INCOMPLETO
            HttpClient client = new();

            #region GET REQUEST

            HttpRequestMessage httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44320/Ordini")
            };

            HttpResponseMessage response = client.SendAsync(httpRequest).Result;

            //(response.StatusCode == System.Net.HttpStatusCode.OK)
            if (response.IsSuccessStatusCode)
            {
                // mi occupo di leggere i dati dal body
                string jsonData = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<Ordine>>(jsonData);

                foreach (var item in result)
                    Console.WriteLine($"[{item.Id}] {item.DataOrdine}\t{item.CodiceOrdine}\t{item.CodiceProdotto}\t{item.ClientiId}");

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine($"Response not Found");
            }  

            #endregion
        }
    }
}
