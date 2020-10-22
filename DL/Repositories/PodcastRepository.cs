using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Repositories
{
    public class PodcastRepository : IRepository<Podcast>

    {
        private DataManager dataManager;
        private List<Podcast> podcastList;

        public PodcastRepository()
        {
            dataManager = new DataManager();
            podcastList = new List<Podcast>();
        }

        public void Create(Podcast podcast)
        {
            podcastList.Add(podcast);
        }

        public void Delete(int index)
        {
            podcastList.RemoveAt(index);
        }

        public void SaveChanges()
        {
            //TODO
        }

        public List<Podcast> GetAllPodCasts()
        {
            //TODO
            return null;
        }
    }
}