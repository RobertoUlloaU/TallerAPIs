using Newtonsoft.Json;
using System.Text;
using TallerAPIs.Interfaces;
using TallerAPIs.Models;

namespace TallerAPIs.Repositories
{
    public class GeminiRepository : IChatbotService
    {
        private HttpClient _httpClient;
        private string geminiApiKey= "AIzaSyDNPJw66lPMWc5YUw81f6P-ry8cRK2-cuQ"
        public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }
        
        public async Task<string> ObtenerRespuestaChatbot(string promt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" + geminiApiKey;
            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text = promt
                            }
                        }
                    }
                }
            };

            string json_data = JsonConvert.SerializeObject(request);
            var content = new StringContent(json_data,Encoding.UTF8, "aplication/json");
            var response= await _httpClient.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }
        public bool GuardarRespuestaBaseDatosLocal(string promt, string respuesta)
        {
            throw new NotImplementedException();
        }

    }
}
