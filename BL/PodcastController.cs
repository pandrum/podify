using Model;
using DL.Repositories;
using System;
using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL
{
    public class PodcastController
    {
        private IRepository<Podcast> podcastRepository;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        public void AddNewPodcast(string url, string name, string category, int interval)
        {
            Podcast podcast = new Podcast(url, name, category, interval);

            podcastRepository.Create(podcast);
        }

        public List<Podcast> GetAllPodcasts()
        {
            return podcastRepository.GetAllPodCasts();
        }

        public void DeletePodcast(int index)
        {
            podcastRepository.Delete(index);
        }

        public static void FetchFeed(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (var item in feed.Items)
            {
                string title = item.Title.Text;
                Console.WriteLine(title);

                var description = item.Summary.Text;
                Console.WriteLine(description);
            }
        }
    }
}