using Model;
using System;
using System.Collections.Generic;

namespace DL.Repositories
{
    public class PodcastRepository : IRepository<Podcast>

    {
        public List<Podcast> podcastList;
        public DataManager dataManager;

        public PodcastRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new DataManager();
            //podcastList = GetAllPodCasts();
        }

        public void Create(Podcast podcast)
        {
            try
            {
                podcastList.Add(podcast);
                SaveChanges();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Fel att lägga till Podcast i PodcastRepository");
            }
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
            catch (InvalidOperationException)
            {
                Console.WriteLine("No list to return.");
            }
            return returnPodcastList;
        }
    }
}