namespace apis_app.Helper {
    public class ClientService {
        private readonly HttpClient httpClient;
    
 
        public ClientService( ) {
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
           
        }


        public class ResponseMessage {
            public string StatusCode { get; set; }
            public object Result { get; set; }
            public string Message { get; set; }
        }
        public async Task<ResponseMessage> Post<T>(string dataEndpointUri, object values) {
            try {
                //var token = await _localStorage.GetItemAsync<string>(Globals.AuthToken);
                //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                //var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(values);
                var response = await httpClient.PostAsJsonAsync(dataEndpointUri, values);

                if (response.StatusCode.ToString().ToUpper() != "OK") {
                    var res = new ResponseMessage() {
                        StatusCode = response.StatusCode.ToString(),
                        Result = 0,
                        Message = "Unauthorized"
                    };
                    return await Task.FromResult(res);
                } else {
                    response.EnsureSuccessStatusCode();
                    var Result = await response.Content.ReadFromJsonAsync<T>();
                    var res = new ResponseMessage() {
                        StatusCode = response.StatusCode.ToString(),
                        Result = Result,
                        Message = "Success"
                    };
                    return await Task.FromResult(res);
                }
            } catch (Exception ex) {
                var httpResMsg = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                var res = new ResponseMessage() {
                    StatusCode = httpResMsg.StatusCode.ToString(),
                    Result = ex.Message,
                    Message = "Error"
                };
                return await Task.FromResult(res);
            }

        }

        public async Task<ResponseMessage> GetAllAsync<T>(string dataEndpointUri) {
            //IEnumerable<T> result = default;
            var res = new ResponseMessage();
            try {
              //  var token = await _localStorage.GetItemAsync<string>(Globals.AuthToken);
               // httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync(dataEndpointUri);

                if (response.StatusCode.ToString() == "Unauthorized") {
                    res.StatusCode = response.StatusCode.ToString();
                    res.Message = "Unauthorized";

                    return await Task.FromResult(res);
                } else {
                    response.EnsureSuccessStatusCode();
                    var Result = await response.Content.ReadFromJsonAsync<T>();

                    res.StatusCode = response.StatusCode.ToString();
                    res.Result = Result;
                    res.Message = "Success";

                    var xx = res;
                    return await Task.FromResult(res);
                }
            } catch (Exception ex) {
                var httpResMsg = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                res.StatusCode = httpResMsg.StatusCode.ToString();
                res.Result = ex.Message;
                res.Message = "Error";

                return await Task.FromResult(res);
            }
        }
    }
}
