using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gundem_app_win.Models
{
    public class ContentModel
    {
        public string ContentText { get; set; }
        public List<string> ContentLink { get; set; }

        public ContentModel()
        {
            ContentLink = new List<string>();
        }
    }
}