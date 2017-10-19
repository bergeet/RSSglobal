using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class Episodes
    {
        private string episodeTitle = null;
        private string episodeUrl = null;

        public string AvsnittsTitel { get; set; }
        public string AvsnittsUrl { get; set; }
        public string AvsnittsMediaUrl { get; set; }

        public Episodes(string titel, string url, string mediaUrl)
        {
            AvsnittsTitel = titel;
            AvsnittsUrl = url;
            AvsnittsMediaUrl = mediaUrl;
        }

        public string GetAvsnittsTitel()
        {
            return episodeTitle;
        }
        public string GetAvsnittsUrl()
        {
            return episodeUrl;
        }

        
    }
}
