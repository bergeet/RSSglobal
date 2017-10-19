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

        public Episodes(string titel, string url)
        {
            AvsnittsTitel = titel;
            AvsnittsUrl = url;
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
