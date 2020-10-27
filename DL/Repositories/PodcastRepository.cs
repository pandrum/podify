using Model;
using System;
using System.Collections.Generic;

namespace DL.Repositories
{
    public class PodcastRepository : IRepository<Podcast>

    {
        public List<Podcast> podcastList;
        public DatamanagerPodcast dataManager;

        public PodcastRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new DatamanagerPodcast();
            podcastList = GetAll();
        }

        public void Create(Podcast podcast)
        {
            podcastList.Add(podcast);
            SaveChanges();
        }

        public void Delete(int index)
        {
            podcastList.RemoveAt(index);
            SaveChanges();
        }

        public void SaveChanges()
        {
            dataManager.Serialize(podcastList);
        }

        public List<Podcast> GetAll()
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