using System;

namespace Model
{
    public class Podcast
    {
        public string URL { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Interval { get; set; }
        public int TotalEpisodes { get; set; }

        public Podcast(string url, string name, string category, int interval, int totalEpisodes)
        {
            URL = url;
            Name = name;
            Category = category;
            Interval = interval;
            TotalEpisodes = totalEpisodes;
        }
    }
}