using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DL.Repositories
{
    public class PodcastRepository : ListCounter, IRepository<Podcast>

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

        public void DeletePodcastsByCategory(string categoryName)
        {
            podcastList.RemoveAll(p => p.Category == categoryName);
            SaveChanges();
        }

        public void Update(int index, Podcast podcast)
        {
            if (index >= 0)
            {
                podcastList[index] = podcast;
            }
            SaveChanges();
        }

        public void UpdatePodcastCategory(string currentName, string newName)
        {
            foreach (var podcast in podcastList.Where(p => p.Category == currentName))
            {
                podcast.Category = newName;
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

        public override void GetNumberOfItems()
        {
            var items = podcastList.Count;
            System.Console.WriteLine("The CategoryRepository has this many items in store: " + items);
        }
    }
}