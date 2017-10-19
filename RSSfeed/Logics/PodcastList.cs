using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class PodcastList
    {
        private List<Podcast> podcastList = new List<Podcast>();
        
        public List<Podcast> GetPodcastList()
        {
            return podcastList;
        }

        public void AddPod(string url, string name, int interval, string category)
        {
            Podcast aPod = new Podcast();
            aPod.Name = name;
            aPod.Url = url;
            aPod.Interval = interval;
            aPod.Category = category;
            podcastList.Add(aPod);
        }

        public void AddPod(Podcast podcast)
        {
            podcastList.Add(podcast);
        }

        public bool isEmpty()
        {
           if(podcastList.Count != 0)
            {
                return false;
            }
           else
            {
                return true;
            }

        }
        
    }
}
