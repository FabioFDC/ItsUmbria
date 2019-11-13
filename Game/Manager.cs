using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Game.Models;

namespace Game
{
    public static class Manager
    {
        public static async Task<List<Lobby>> GetListLobby()
        {
            List<Lobby> myList = new List<Lobby>();
            HttpClient cl = new HttpClient();
            HttpResponseMessage response = await cl.GetAsync(Config.Urls.BaseUrl + Config.Urls.ListLobbyUrl);

            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
                    string result = await content.ReadAsStringAsync();
                    myList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lobby>>(result);
                        }
            }
            else
            {
                cl.Dispose();
                throw new HttpRequestException(response.ReasonPhrase);
            }

            cl.Dispose();
            return myList;
        }

        public static async Task<Lobby> GetLobbyStatus(int id)
        {
            Lobby myLobby = new Lobby();
            HttpClient cl = new HttpClient();
            string urlfinale = string.Format(Config.Urls.StatusLobbyUrl, id);

            HttpResponseMessage response = await cl.GetAsync(Config.Urls.BaseUrl + urlfinale);

            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
                    string result = await content.ReadAsStringAsync();
                    myLobby = Newtonsoft.Json.JsonConvert.DeserializeObject<Lobby>(result);
                }
            }
            else
            {
                cl.Dispose();
                throw new HttpRequestException(response.ReasonPhrase);
            }

            cl.Dispose();
            return myLobby;
        }
    }
}
