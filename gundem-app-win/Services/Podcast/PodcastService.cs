using gundem_app_win.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gundem_app_win.Services.Podcast
{
    public class PodcastService : IPodcastService
    {
        public List<PodcastModel> GetPodcasts()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //var response = client.GetAsync(ConfigurationManager.AppSettings["GetPodcastsApiUrl"].ToString());
                    var response = client.GetAsync("https://raw.githubusercontent.com/tsopenteam/gundem/master/gundem.json").Result;
                    RootModel rootModel = JsonConvert.DeserializeObject<RootModel>(response.Content.ReadAsStringAsync().Result);

                    return rootModel.List;
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}