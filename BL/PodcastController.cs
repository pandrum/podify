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
            List<Episode> episodes = GetEpisodes(url);
            Podcast podcast = new Podcast(url, name, category, interval, episodes);

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

        public List<Episode> GetEpisodes(string url)
        {
            List<Episode> episodes = new List<Episode>();
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (var item in feed.Items)
            {
                Episode episode = new Episode();
                string title = item.Title.Text;
                episode.Name = title;

                var description = item.Summary.Text;
                episode.Description = description;

                Console.WriteLine(episode.Name);
                Console.WriteLine(episode.Description);

                episodes.Add(episode);
            }
            return episodes;
        }
    }
}