using gundem_app_win.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gundem_app_win.Services.Podcast
{
    public interface IPodcastService
    {
        List<PodcastModel> GetPodcasts();
    }
}