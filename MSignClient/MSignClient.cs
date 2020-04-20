using RestSharp;
using RestSharp.Serialization;
using System;

using Newtonsoft.Json;
using RestSharp.Serialization;

namespace MSignClient
{
    class MSignClient
    {
        public static Document1Response document1(string baseUrl, string token, Document1 document1)
        {
            var client = new RestClient(baseUrl);

            var request = new RestRequest("documents1", DataFormat.Json);
            request.Method = Method.POST;
            request.AddJsonBody(document1);
            request.AddHeader("AccessToken", token);

            IRestResponse<Document1Response> response = client.Execute<Document1Response>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return response.Data;
            }
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorMessage);

            return null;
        }
    }
}
