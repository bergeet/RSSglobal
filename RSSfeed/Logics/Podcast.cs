using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Logics
{
    public class Podcast
    {
        private string url;
        private string name;
        private int interval;
        private string category;
        private List<Episodes> episodeList;
        Timer aTimer = new Timer();

        public string Category { get; set; } 
        public string Url { get; set; }
        public string Name { get; set; }
        public int Interval { get; set; }

        public Podcast()
        {
            setTimer();
        }

        public List<Episodes> GetEpisodes()
        {
            episodeList = Episodefetch.FetchEpisodes(Url);
            return episodeList;
        }

        private void setTimer()
        {
            if(interval != 0)
            {
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                aTimer.Interval = interval;
                aTimer.Enabled = true;
            }
            
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
           episodeList = Episodefetch.FetchEpisodes(Url);
        }


        // private Category category;

    }
}
