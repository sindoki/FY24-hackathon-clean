using System.Text.Json;
using System.Text;
using System.Net.Http;

namespace MSBingMapsExtended.Services
{
    public class GraphQLService
    {
        private const string GraphQLBaseApiUrl = "http://localhost:5044";

        private HttpClient HttpClient;

        public GraphQLService()
        {
            HttpClient = new HttpClient {
                BaseAddress = new Uri(GraphQLBaseApiUrl)
            };
        }

        public string GetGraphQLSchema()
        {
            using HttpResponseMessage response = HttpClient.GetAsync("api/schema").Result;
            response.EnsureSuccessStatusCode();
            string jsonResponse = response.Content.ReadAsStringAsync().Result;

            return jsonResponse;
        }

        public string ExecuteGraphQuery(string jsonRequest, string placeName = null)
        {
            if (placeName != null)
                jsonRequest = InjectPlaceName(jsonRequest, placeName);

            jsonRequest = jsonRequest.Replace("\r", "").Replace("\n", "");

            using StringContent jsonContent = new StringContent($"{{\"query\": \"{jsonRequest}\"}}", Encoding.UTF8, "application/json");
            using HttpResponseMessage response = HttpClient.PostAsync("graphql", jsonContent).Result;
            response.EnsureSuccessStatusCode();
            string jsonResponse = response.Content.ReadAsStringAsync().Result;

            return jsonResponse;
        }

        private string InjectPlaceName(string jsonRequest, string placeName)
        {
            jsonRequest = jsonRequest.Replace("restaurants", "restaurant"); // workaround

            int mainStart = -1,
                mainEnd = -1;

            for (int i = 0; i < jsonRequest.Length; i++)
            {
                if (mainStart < 0) 
                { 
                    if (char.IsLetter(jsonRequest[i]))
                        mainStart = i;
                }
                else if (mainEnd < 0 && !char.IsLetter(jsonRequest[i]))
                {
                    mainEnd = i - 1;
                    break;
                }
            }

            if (mainEnd < 0)
                return jsonRequest;

            string mainName = jsonRequest.Substring(mainStart, mainEnd - mainStart + 1);

            return jsonRequest.Remove(mainStart, mainEnd - mainStart + 1)
                              .Insert(mainStart, $"{mainName}(name: \\\"{placeName}\\\")");
        }

    }
}
