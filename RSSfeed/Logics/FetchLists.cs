using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class FetchLists
    {
        PodcastList podcastList = new PodcastList();

        public FetchLists()
        {
            XmlCommunication.loadPodcasts(podcastList);
        }

        public List<Episodes> loadEpisodes(string equals)
        {
            List<Episodes> episodes = new List<Episodes>();
            foreach (var podcast in podcastList.GetPodcastList())
            {
                if (podcast.Name == equals)
                {
                    episodes = podcast.GetEpisodes();

                }

            }
            return episodes;
        }

       public async Task<List<Episodes>> loadEpisodesTask(string equals)
        {
            List<Episodes> episodes = new List<Episodes>();
            foreach (var podcast in podcastList.GetPodcastList())
            {
                if (podcast.Name == equals)
                {
                    episodes = podcast.GetEpisodes();
                    List<Episodes> list = await Task.Run(() => podcast.GetEpisodes());
                }

            }
            
            return episodes;
        }



    }
}
