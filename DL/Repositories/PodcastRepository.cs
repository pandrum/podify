using Model;
using System;
using System.Collections.Generic;

namespace DL.Repositories
{
    public class PodcastRepository : IRepository<Podcast>

    {
        private List<Podcast> podcastList;
        private DataManager dataManager;

        public PodcastRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new DataManager();
            //podcastList = GetAllPodCasts();
        }

        public void Create(Podcast podcast)
        {
            podcastList.Add(podcast);

            SaveChanges();
        }

        public void Delete(int index)
        {
            podcastList.RemoveAt(index);
        }

        public void SaveChanges()
        {
            dataManager.Serialize(podcastList);
        }

        public List<Podcast> GetAllPodCasts()
        {
            List<Podcast> returnPodcastList = new List<Podcast>();
            try
            {
                returnPodcastList = dataManager.Deserialize();
            }
            catch (Exception)
            {
                Console.WriteLine("No list to return.");
            }
            return returnPodcastList;
        }
    }
}