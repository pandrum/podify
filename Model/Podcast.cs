using System;

namespace Model
{
    public class Podcast
    {
        public string URL { get; set; }
        public string Name { get; set; }
        public  string Category { get; set; }
        public int Interval { get; set; }
        public int TotalOfEpisodes { get; set; }

        public Podcast (string aUrl, string aName, string aCategory, int aInterval, int aTotalOfEpisodes)

        {
            URL = aUrl;
            Name = aName;
            Category = aCategory;
            Interval = aInterval;
            TotalOfEpisodes = aTotalOfEpisodes;
        }

    }
}