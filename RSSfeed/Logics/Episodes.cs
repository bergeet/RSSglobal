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

        public string _avsnittsTitel { get; set; }
        public string _avsnittsUrl { get; set; }

        public Episodes(string titel, string url)
        {
            episodeTitle = titel;
            episodeUrl = url;
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
