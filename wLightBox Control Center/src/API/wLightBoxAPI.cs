using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace wLightBox_Control_Center.src
{
    internal class wLightBoxAPI
    {
        //All API instructions are provided here https://technical.blebox.eu/openapi_wlightbox/openAPI_wLightBox_20190808.html

        readonly RestClient _client;
        public wLightBoxAPI(IPAddress ip)
        {
            _client = new RestClient(ip.MapToIPv4().ToString());
        }

        //
        // General
        //
        public Task<string> GetDeviceInfo()
            => _client.GetAsync<string>(new RestRequest("/api/device/state", Method.Get));

        public Task<string> GetDeviceUpTime()
            => _client.GetAsync<string>(new RestRequest("/api/device/uptime", Method.Get));

        public Task UpdateFirmware()
            => _client.PostAsync<string>(new RestRequest("/api/ota/update", Method.Post));

        //
        //Network
        //
        public Task<string> GetNetworkInfo()
            => _client.GetAsync<string>(new RestRequest("/api/device/network", Method.Get));

        public Task SetAccessPoint(bool enabled, string SSID, string password)
        {
            string json = JsonConvert.SerializeObject(new
            {
                apEnable = enabled,
                apSSID = SSID,
                apPasswd = password
            });
            var request = new RestRequest("/api/device/set", Method.Post)
                .AddJsonBody(json);

            return _client.PostAsync(request);
        }

        public Task<string> WifiScan()
            => _client.GetAsync<string>(new RestRequest("/api/wifi/scan", Method.Get));

        public Task WifiConnect(string SSID, string password)
        {
            string json = JsonConvert.SerializeObject(new
            {
                ssid = SSID,
                pwd = password
            });
            var request = new RestRequest("/api/wifi/connect", Method.Post)
                .AddJsonBody(json);

            return _client.PostAsync(request);
        }

        public Task WifiDisconnect(string SSID, string password)
            => _client.GetAsync<string>(new RestRequest("/api/wifi/disconnect", Method.Post));

        //
        //Control & State
        //
        public Task<string> GetLightingInfo()
            => _client.GetAsync<string>(new RestRequest("/api/rgbw/state", Method.Get));

        public Task SetLightning(int effectID, string hexRGBW, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
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
            var request = new RestRequest("/api/rgbw/set", Method.Post)
                .AddJsonBody(json);

            return _client.PostAsync(request);
        }

        public Task SetLightning(int effectID, int r, int g, int b, int w, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
        {
            string hexRGBW = $"{r:X2}{g:X2}{b:X2}{w:X2}";
            return SetLightning(effectID, hexRGBW, colorFadeMs, effectFadeMs, effectStepMs);
        }

        public Task<string> GetExtendedLightingInfo()
            => _client.GetAsync<string>(new RestRequest("/api/rgbw/extended/state", Method.Get));

        //
        //Settings
        //
        public Task<string> GetDeviceSettings()
            => _client.GetAsync<string>(new RestRequest("/api/settings/state", Method.Get));

        public Task SetDeviceSettings(string name, bool tunnelEnabled, bool ledEnabled)
        {
            string tunnelEnabledDigit = tunnelEnabled ? "1" : "0";
            string ledEnabledDigit = ledEnabled ? "1" : "0";

            string json = JsonConvert.SerializeObject(new
            {
                deviceName = name,
                tunnel = JsonConvert.SerializeObject(new { 
                    enabled = tunnelEnabledDigit
                }),
                statusLed = JsonConvert.SerializeObject(new
                {
                    enabled = ledEnabledDigit
                })
            });
            var request = new RestRequest("/api/rgbw/set", Method.Post)
                .AddJsonBody(json);

            return _client.PostAsync(request);
        }
    }
}
