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
    public class wLightBoxAPI
    {
        //All API instructions are provided here https://technical.blebox.eu/openapi_wlightbox/openAPI_wLightBox_20190808.html

        readonly RestClient _client;
        public wLightBoxAPI(string ip)
        {
            _client = new RestClient("https://" + ip + "/");
        }

        //
        // General
        //
        public string GetDeviceInfo()
            => _client.ExecuteGetAsync(new RestRequest("api/device/state")).Result.Content;
        public string GetDeviceUpTime()
            => _client.ExecuteGetAsync(new RestRequest("api/device/uptime")).Result.Content;

        public string UpdateFirmware()
            => _client.ExecutePostAsync(new RestRequest("api/ota/update")).Result.Content;

        //
        //Network
        //
        public string GetNetworkInfo()
            => _client.ExecuteGetAsync(new RestRequest("api/device/network")).Result.Content;

        public string SetAccessPoint(bool enabled, string SSID, string password)
        {
            string json = JsonConvert.SerializeObject(new
            {
                apEnable = enabled,
                apSSID = SSID,
                apPasswd = password
            });
            var request = new RestRequest("/api/device/set")
                .AddJsonBody(json);

            return _client.ExecutePostAsync(request).Result.Content;
        }

        public string WifiScan()
            => _client.ExecuteGetAsync(new RestRequest("api/wifi/scan")).Result.Content;

        public string WifiConnect(string SSID, string password)
        {
            string json = JsonConvert.SerializeObject(new
            {
                ssid = SSID,
                pwd = password
            });
            var request = new RestRequest("/api/wifi/connect")
                .AddJsonBody(json);

            return _client.ExecutePostAsync(request).Result.Content;
        }

        public string WifiDisconnect(string SSID, string password)
            => _client.ExecutePostAsync(new RestRequest("api/wifi/disconnect")).Result.Content;

        //
        //Control & State
        //
        public string GetLightingInfo()
            => _client.ExecuteGetAsync(new RestRequest("api/rgbw/state")).Result.Content;

        public string SetLightning(int effectID, string hexRGBW, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
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

            return _client.ExecutePostAsync(request).Result.Content;
        }

        public string SetLightning(int effectID, int r, int g, int b, int w, int colorFadeMs = 1000, int effectFadeMs = 1500, int effectStepMs = 2000)
        {
            string hexRGBW = $"{r:X2}{g:X2}{b:X2}{w:X2}";
            return SetLightning(effectID, hexRGBW, colorFadeMs, effectFadeMs, effectStepMs);
        }

        public string GetExtendedLightingInfo()
                        => _client.ExecuteGetAsync(new RestRequest("api/rgbw/extended/state")).Result.Content;

        //
        //Settings
        //
        public string GetDeviceSettings()
            => _client.ExecuteGetAsync(new RestRequest("api/settings/state")).Result.Content;

        public string SetDeviceSettings(string name, bool tunnelEnabled, bool ledEnabled)
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
            var request = new RestRequest("/api/rgbw/set")
                .AddJsonBody(json);

            return _client.ExecutePostAsync(request).Result.Content;
        }
    }
}
