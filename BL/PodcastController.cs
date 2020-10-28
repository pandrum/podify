using Model;
using DL.Repositories;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System;

namespace BL
{
    public class PodcastController
    {
        private PodcastRepository podcastRepository;
        private XDocument urlDocument = new XDocument();

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        public string GetPodcastUrl(int index)
        {
            var podcastList = podcastRepository.GetAll();
            Podcast podcast = podcastList[index];
            string url = podcast.Url;
            return url;
        }

        public string GetPodcastName(int index)
        {
            var podcastList = podcastRepository.GetAll();
            Podcast podcast = podcastList[index];
            string name = podcast.Name;
            return name;
        }

        public string GetPodcastUpdateInterval(int index)
        {
            var podcastList = podcastRepository.GetAll();
            Podcast podcast = podcastList[index];
            string interval = podcast.Interval.ToString();
            return interval;
        }

        public string GetPodcastCategory(int index)
        {
            var podcastList = podcastRepository.GetAll();
            Podcast podcast = podcastList[index];
            string category = podcast.Category;
            return category;
        }

        public void UpdatePodcastInfo(int index, string url, string name, string interval, string category)
        {
            var podcastList = podcastRepository.GetAll();
            Podcast podcast = podcastList[index];
            podcast.Url = url;
            podcast.Name = name;
            podcast.Interval = Convert.ToInt32(interval);
            podcast.Category = category;
            podcastRepository.UpdateList(podcast);
        }

        public void AddNewPodcast(string url, string name, string category, int interval)
        {
            List<Episode> episodes = GetEpisodesForPodcast2(url);
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

        //public List<Episode> GetEpisodesForPodcast(string url)
        //{
        //    List<Episode> episodes = new List<Episode>();
        //    XmlReader reader = XmlReader.Create(url);
        //    SyndicationFeed feed = SyndicationFeed.Load(reader);

        //    foreach (var item in feed.Items)
        //    {
        //        Episode episode = new Episode();
        //        episode.Name = item.Title.Text;
        //        episode.Description = item.Summary.Text;
        //        episodes.Add(episode);
        //    }
        //    return episodes;
        //}

        public List<Episode> GetEpisodesForPodcast2(string url)
        {
            List<Episode> episodeList = new List<Episode>();
            {
                urlDocument = XDocument.Load(url);
                episodeList = (from x in urlDocument.Descendants("item")
                               select new Episode
                               {
                                   Name = x.Element("title").Value,
                                   Description = x.Element("description").Value
                               }).ToList();
            };
            return episodeList;
        }
    }
}