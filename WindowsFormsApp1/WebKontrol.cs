using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string userName { get; set; }
        [JsonProperty(".issued")]
        public string issued { get; set; }
        [JsonProperty(".expires")]
        public string expires { get; set; }
    }

    public class WebKontrol
    {
        public Token GetToken(string url, string userName, string password)
        {
            var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>( "grant_type", "password" ),
                        new KeyValuePair<string, string>( "username", userName ),
                        new KeyValuePair<string, string> ( "Password", password )
                    };
            var content = new FormUrlEncodedContent(pairs);
            //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, content).Result;
                string strResult = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrWhiteSpace(strResult))
                {
                    Token t = JsonConvert.DeserializeObject<Token>(strResult);
                    return t;
                }
                return new Token();
            }
        }
        public Token GetAsker(string url, string strToken)
        {
            var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>( "Content-Type", "application/json" ),
                        new KeyValuePair<string, string>( "Authorization", "Bearer " + strToken )                        
                    };
            var header = new FormUrlEncodedContent(pairs);
            //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                //client.DefaultRequestHeaders.Add(pairs[0,0], pairs[0,1]);

                var response = client.GetAsync(url).Result;
                string strResult = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrWhiteSpace(strResult))
                {
                    Token t = JsonConvert.DeserializeObject<Token>(strResult);
                    return t;
                }
                return new Token();
            }
        }
    }
}
