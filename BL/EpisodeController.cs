using DL.Repositories;
using Model;
using System.Collections.Generic;

namespace BL
{
    public class EpisodeController
    {
        private EpisodeRepository episodeRepository;

        public EpisodeController()
        {
            episodeRepository = new EpisodeRepository();
        }

        public List<Episode> GetAllEpisodesFromPodcast(int index)
        {
            return episodeRepository.GetAll(index);
        }
    }
}