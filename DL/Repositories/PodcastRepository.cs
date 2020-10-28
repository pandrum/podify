using Model;
using System;
using System.Collections.Generic;

namespace DL.Repositories
{
    public class PodcastRepository : IRepository<Podcast>

    {
        public PodcastDataManager dataManager;
        public List<Podcast> podcastList;

        public PodcastRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new PodcastDataManager();
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

        public void Update(int index, Podcast podcast)
        {
            //for (int i = 0; i < podcastList.Count; i++)
            //{
            //    if (podcastList[i].Url.Equals(podcast.Url))
            //    {
            //        podcastList[i] = podcast;
            //    }
            //}

            if (index >= 0)
            {
                podcastList[index] = podcast;
            }

            SaveChanges();
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

        public void SaveChanges()
        {
            dataManager.Serialize(podcastList);
        }
    }
}