using Model;
using DL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;
using System;

namespace BL
{
    public class PodcastController
    {
        private PodcastRepository podcastRepository;
        private List<Podcast> podcastList;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            podcastList = podcastRepository.GetAll();
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

        public void UpdateAllPodcastInfo(int index, string url, string name, string interval, string category)
        {
            var podcastList = podcastRepository.GetAll();
            Podcast podcast = podcastList[index];
            podcast.Url = url;
            podcast.Name = name;
            podcast.Interval = Convert.ToInt32(interval);
            podcast.Category = category;
            podcastRepository.Update(index, podcast);
        }

        public void UpdatePodcastCategory(string currentName, string newName)
        {
            podcastRepository.UpdatePodcastCategory(currentName, newName);
        }

        public async Task<Podcast> AddNewPodcast(string url, string name, string category, int interval)
        {
            Podcast podcast = new Podcast();
            await Task.Run(() =>
            {
                var episodes = GetEpisodesForPodcast(url);
                Podcast p = new Podcast(url, name, category, interval, episodes);

                podcastRepository.Create(p);
            });
            return podcast;
        }

        public List<Podcast> GetPodcasts()
        {
            return podcastRepository.GetAll();
        }

        public void DeletePodcast(int index)
        {
            podcastRepository.Delete(index);
        }

        public void DeletePodcastByCategory(string categoryName)
        {
            podcastRepository.DeletePodcastsByCategory(categoryName);
        }

        public List<Episode> GetEpisodesForPodcast(string url)
        {
            List<Episode> episodes = new List<Episode>();
            XDocument urlDocument = new XDocument();

            {
                urlDocument = XDocument.Load(url);
                episodes = (from x in urlDocument.Descendants("item")
                            select new Episode
                            {
                                Name = x.Element("title").Value,
                                Description = x.Element("description").Value
                            }).ToList();
            };
            return episodes;
        }

        public void CheckForNewEpisodes(string url)
        {
            Console.WriteLine("podcastController");
            var newEpisodes = GetEpisodesForPodcast(url);
            foreach (var item in newEpisodes)
            {
                Console.WriteLine(item.Name);
            }
            podcastRepository.UpdatePodcastEpisodes(url, newEpisodes);
        }
    }
}