using apis_app.Data.ML.Weather.WaterBoard;
using apis_app.Helper;

namespace apis_app.Data.DA.Weather {
    public class WaterService {



        private ClientService _clientService;
        public WaterService(ClientService clientService) {
            _clientService = clientService;
        }

        async public Task<BasicInfo> GetBasicInfo() {
            BasicInfo output = new BasicInfo();
            try { 
                string url = $"{Globals.BaseURL}/api/weather/waterboard/GetBasicInfo";
                var query = await Task.Run(() => _clientService.GetAllAsync<BasicInfo>(url));
                output = (BasicInfo)query.Result;
            } catch (Exception ex) {
            }
            return output;
        }

     async public Task<RainFallInfo> GetRainFallInfo() {
            RainFallInfo output = new RainFallInfo();
            try { 
                string url = $"{Globals.BaseURL}/api/weather/waterboard/GetRainFallInfo";
                var query = await Task.Run(() => _clientService.GetAllAsync<RainFallInfo>(url));
                output = (RainFallInfo)query.Result;
            } catch (Exception ex) {
            }
            return output;
        }
        async public Task<DamInfo> GetDamInfo() {
            DamInfo output = new DamInfo();
            try {
                string url = $"{Globals.BaseURL}/api/weather/waterboard/GetDamInfo";
                var query = await Task.Run(() => _clientService.GetAllAsync<DamInfo>(url));
                output = (DamInfo)query.Result;
            } catch (Exception ex) {
            }
            return output;
        }
        async public Task<StormInfo> GetStorm() {
            StormInfo output = new StormInfo();
            try {
                string url = $"{Globals.BaseURL}/api/weather/waterboard/GetStormInfo";
                var query = await Task.Run(() => _clientService.GetAllAsync<StormInfo>(url));
                output = (StormInfo)query.Result;
            } catch (Exception ex) {
            }
            return output;
        }
    }
}
