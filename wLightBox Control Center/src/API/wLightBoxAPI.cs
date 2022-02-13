using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.Web;

namespace wLightBox_Control_Center.src
{
    public class wLightBoxAPI
    {
        //All API instructions are provided here https://technical.blebox.eu/openapi_wlightbox/openAPI_wLightBox_20190808.html

        private RestClient _client;
        private string ip;
        private int dataPostTimeout = 5000;

        public wLightBoxAPI(string ip)
        {
            this.ip = ip;
            RestClientOptions options = new RestClientOptions("https://" + ip + "/")
            {
                Timeout = dataPostTimeout
            };
            _client = new RestClient(options);
        }

        public void ChangeIP(string ip)
        {
            this.ip = ip;
            RestClientOptions options = new RestClientOptions("https://" + ip + "/")
            {
                Timeout = dataPostTimeout
            };
            _client = new RestClient(options);
        }

        //
        // General
        //
        public string GetDeviceInfo()
        {
            try { return _client.ExecuteGetAsync(new RestRequest("api/device/state")).Result.Content; }
            catch (Exception) { return null; }
        }
        public async Task<string> GetDeviceInfoAsync()
        {
            try { return await _client.GetJsonAsync<string>("api/device/state"); }
            catch (Exception) { return null; }
        }
        public string GetDeviceUpTime()
        {
            try { return _client.ExecuteGetAsync(new RestRequest("api/device/uptime")).Result.Content; }
            catch (Exception) { return null; }
        }
        public async Task<string> GetDeviceUpTimeAsync()
        {
            try { return await _client.GetJsonAsync<string>("api/device/state"); }
            catch (Exception) { return null; }
        }

        public HttpStatusCode UpdateFirmware()
        {
            try { return _client.ExecutePostAsync(new RestRequest("api/ota/update")).Result.StatusCode; }
            catch (Exception) { return HttpStatusCode.Conflict; }
        }

        public async Task<HttpStatusCode> UpdateFirmwareAsync()
        {
            try { return await _client.PostJsonAsync("api/ota/update", new RestRequest()); }
            catch (Exception) { return HttpStatusCode.Conflict; }
        }

        //
        //Network
        //
        public string GetNetworkInfo()
        {
            try { return _client.ExecuteGetAsync(new RestRequest("api/device/network")).Result.Content; }
            catch (Exception) { return null; }
        }

        public async Task<string> GetNetworkInfoAsync()
        {
            try { return await _client.GetJsonAsync<string>("api/device/network"); }
            catch (Exception) { return null; }
        }

        public HttpStatusCode SetAccessPoint(bool enabled, string SSID, string password)
        {
            try
            {
                string json = JsonConvert.SerializeObject(new
                {
                    apEnable = enabled,
                    apSSID = SSID,
                    apPasswd = password
                });
                var request = new RestRequest("/api/device/set")
                    .AddJsonBody(json);

                return _client.ExecutePostAsync(request).Result.StatusCode;
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public async Task<HttpStatusCode> SetAccessPointAsync(bool enabled, string SSID, string password)
        {
            try
            {
                string json = JsonConvert.SerializeObject(new
                {
                    apEnable = enabled,
                    apSSID = SSID,
                    apPasswd = password
                });
                var request = new RestRequest()
                    .AddJsonBody(json);

                return await _client.PostJsonAsync("/api/device/set", request);
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public string WifiScan()
        {
            try { return _client.ExecuteGetAsync(new RestRequest("api/wifi/scan")).Result.Content; }
            catch (Exception) { return null; }
        }

        public async Task<string> WifiScanAsync()
        {
            try { return await _client.GetJsonAsync<string>("api/wifi/scan"); }
            catch (Exception) { return null; }
        }

        public HttpStatusCode WifiConnect(string SSID, string password)
        {
            try
            {
                string json = JsonConvert.SerializeObject(new
                {
                    ssid = SSID,
                    pwd = password
                });
                var request = new RestRequest("/api/wifi/connect")
                    .AddJsonBody(json);

                return _client.ExecutePostAsync(request).Result.StatusCode;
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public async Task<HttpStatusCode> WifiConnectAsync(string SSID, string password)
        {
            try
            {
                string json = JsonConvert.SerializeObject(new
                {
                    ssid = SSID,
                    pwd = password
                });
                var request = new RestRequest()
                    .AddJsonBody(json);

                return await _client.PostJsonAsync("/api/wifi/connect", request);
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public HttpStatusCode WifiDisconnect(string SSID, string password)
        {
            try { return _client.ExecutePostAsync(new RestRequest("api/wifi/disconnect")).Result.StatusCode; }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public async Task<HttpStatusCode> WifiDisconnectAsync(string SSID, string password)
        {
            try { return await _client.PostJsonAsync("api/wifi/disconnect", new RestRequest()); }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        //
        //Control & State
        //
        public string GetLightingInfo()
        {
            try { return _client.ExecuteGetAsync(new RestRequest("api/rgbw/state")).Result.Content; }
            catch (Exception) { return null; }
        }

        public async Task<string> GetLightingInfoAsync()
        {
            try { return await _client.GetJsonAsync<string>("api/rgbw/state"); }
            catch (Exception) { return null; }
        }

        public HttpStatusCode SetLightning(int effectID, string hexRGBW, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
        {
            try
            {
                string json = JsonConvert.SerializeObject(new
                {
                    effectID = effectID,
                    desiredColor = hexRGBW,
                    durationMs = JsonConvert.SerializeObject(new
                    {
                        colorFade = colorFadeMs,
                        effectFade = effectFadeMs,
                        colorStep = effectStepMs
                    })
                });
                var request = new RestRequest("/api/rgbw/set")
                    .AddJsonBody(json);

                return _client.ExecutePostAsync(request).Result.StatusCode;
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public async Task<HttpStatusCode> SetLightningAsync(int effectID, string hexRGBW, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
        {
            try
            {
                string json = JsonConvert.SerializeObject(new
                {
                    effectID = effectID,
                    desiredColor = hexRGBW,
                    durationMs = JsonConvert.SerializeObject(new
                    {
                        colorFade = colorFadeMs,
                        effectFade = effectFadeMs,
                        colorStep = effectStepMs
                    })
                });
                var request = new RestRequest()
                    .AddJsonBody(json);

                return await _client.PostJsonAsync("/api/rgbw/set", request);
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public HttpStatusCode SetLightning(int effectID, int r, int g, int b, int w, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
        {
            string hexRGBW = $"{r:X2}{g:X2}{b:X2}{w:X2}";
            return SetLightning(effectID, hexRGBW, colorFadeMs, effectFadeMs, effectStepMs);
        }

        public async Task<HttpStatusCode> SetLightningAsync(int effectID, int r, int g, int b, int w, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
        {
            string hexRGBW = $"{r:X2}{g:X2}{b:X2}{w:X2}";
            return await SetLightningAsync(effectID, hexRGBW, colorFadeMs, effectFadeMs, effectStepMs);
        }

        //
        //Settings
        //
        public string GetDeviceSettings()
        {
            try { return _client.ExecuteGetAsync(new RestRequest("api/settings/state")).Result.Content; }
            catch (Exception) { return null; }
        }

        public async Task<string> GetDeviceSettingsAsync()
        {
            try { return await _client.GetJsonAsync<string>("api/settings/state"); }
            catch (Exception) { return null; }
        }

        public HttpStatusCode SetDeviceSettings(string name, bool tunnelEnabled, bool ledEnabled)
        {
            try
            {
                string tunnelEnabledDigit = tunnelEnabled ? "1" : "0";
                string ledEnabledDigit = ledEnabled ? "1" : "0";

                string json = JsonConvert.SerializeObject(new
                {
                    deviceName = name,
                    tunnel = JsonConvert.SerializeObject(new
                    {
                        enabled = tunnelEnabledDigit
                    }),
                    statusLed = JsonConvert.SerializeObject(new
                    {
                        enabled = ledEnabledDigit
                    })
                });
                var request = new RestRequest("/api/rgbw/set")
                    .AddJsonBody(json);

                return _client.ExecutePostAsync(request).Result.StatusCode;
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }

        public async Task<HttpStatusCode> SetDeviceSettingsAsync(string name, bool tunnelEnabled, bool ledEnabled)
        {
            try
            {
                string tunnelEnabledDigit = tunnelEnabled ? "1" : "0";
                string ledEnabledDigit = ledEnabled ? "1" : "0";

                string json = JsonConvert.SerializeObject(new
                {
                    deviceName = name,
                    tunnel = JsonConvert.SerializeObject(new
                    {
                        enabled = tunnelEnabledDigit
                    }),
                    statusLed = JsonConvert.SerializeObject(new
                    {
                        enabled = ledEnabledDigit
                    })
                });
                var request = new RestRequest()
                    .AddJsonBody(json);

                return await _client.PostJsonAsync("/api/rgbw/set", request);
            }
            catch (Exception) { return HttpStatusCode.BadRequest; }
        }
    }
}
