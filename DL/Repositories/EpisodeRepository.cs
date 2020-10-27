using Model;
using System;
using System.Collections.Generic;

namespace DL.Repositories
{
    public class EpisodeRepository
    {
        public List<Episode> episodeList;
        public List<Podcast> podcastList;
        public DatamanagerPodcast dataManager;

        public EpisodeRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new DatamanagerPodcast();
        }

        public List<Episode> GetAll(int index)
        {
            try
            {
                podcastList = dataManager.Deserialize();
                Podcast podcast = podcastList[index];
                episodeList = podcast.Episodes;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            return episodeList;
        }
    }
}