
using System.Text;
using Newtonsoft.Json;

namespace RabbitAPI.Services;

public static class MessageSender
{
    public static async Task PostMessage(string postData)
    {
        var json = JsonConvert.SerializeObject(postData);
        var content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
        
        using (var httpClientHandler = new HttpClientHandler())
        {
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            using (var client = new HttpClient(httpClientHandler))
            {
                var result = await client.PostAsync("https://localhost:5001/api/values", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine("Server returned: " + resultContent);
            }
        }
    }

}