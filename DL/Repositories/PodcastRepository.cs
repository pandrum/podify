using Model;
using DL;
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
            foreach (var item in podcastList)
            {
                Console.WriteLine(item.URL);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.Interval);
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
            //TODO
            return null;
        }
    }
}