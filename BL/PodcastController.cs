using Model;
using DL.Repositories;
using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL
{
    public class PodcastController
    {
        private PodcastRepository podcastRepository;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        public void AddNewPodcast(string url, string name, string category, int interval)
        {
            List<Episode> episodes = GetEpisodesForPodcast(url);
            Podcast p = new Podcast(url, name, category, interval, episodes);

            podcastRepository.Create(p);
        }

        public List<Podcast> GetAllPodcasts()
        {
            return podcastRepository.GetAll();
        }

        public void DeletePodcast(int index)
        {
            podcastRepository.Delete(index);
        }

        public List<Episode> GetEpisodesForPodcast(string url)
        {
            List<Episode> episodes = new List<Episode>();
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (var item in feed.Items)
            {
                Episode episode = new Episode();

                string title = item.Title.Text;
                string description = item.Summary.Text;
                episode.Name = title;
                episode.Description = description;

                episodes.Add(episode);
            }
            return episodes;
        }
    }
}