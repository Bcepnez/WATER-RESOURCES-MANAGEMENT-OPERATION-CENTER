using System.Text;
using System.Text.Json;

namespace apis_app.Helper {
    public class APIHelper {



        //<!-- Method for request API service via POST request and response as object -->
        private async Task<object> post_request(string url, object postBody) {
            HttpClient HttpClient = new HttpClient();
            //< !--create request object -->
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            //< !--Console.WriteLine(JsonSerializer.Serialize(postBody)); -->
            request.Content = new StringContent(JsonSerializer.Serialize(postBody), Encoding.UTF8, "application/json");

            //< !--add authorization header -->
            //< !--request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "my-token"); -->
            //< !--add custom http header-- >
            request.Headers.Add("appId", "test-000001");
            request.Headers.Add("appSecret", "12345678900987654321");
            request.Headers.Add("device-uuid", "B765CF34-47BC-4493-8B5B-E85184DC34B3");

            //< !--send request-- >
            var response = await HttpClient.SendAsync(request);

            //< !--convert response data to Article object -->
            var article = await response.Content.ReadFromJsonAsync<object>();
            return article;
        }
    }
}
