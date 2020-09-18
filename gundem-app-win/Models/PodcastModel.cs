using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gundem_app_win.Models
{
    public class PodcastModel
    {
        public string Year { get; set; }
        public int Count { get; set; }
        public int TotalCount { get; set; }
        public string UploadDate { get; set; }
        public string PodcastLink { get; set; }
        public string VideoLink { get; set; }
        public string SiteLink { get; set; }
        public string RangeFirstDate { get; set; }
        public string RangeLastDate { get; set; }
        public string TitlePodcast { get; set; }
        public string ExplanationPodcast { get; set; }
        public List<ContentModel> Content { get; set; }

        public PodcastModel()
        {
            Content = new List<ContentModel>();
        }
    }
}