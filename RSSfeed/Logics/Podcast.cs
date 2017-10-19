using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class Podcast
    {
        private string url;
        private string name;
        private int interval;
        private string category;
        private List<Episodes> episodeList;

        public string Category { get; set; } 
        public string Url { get; set; }
        public string Name { get; set; }
        public int Interval { get; set; }

        public List<Episodes> GetEpisodes()
        {
            return episodeList;
        }

        // private Category category;
    
    }
}
