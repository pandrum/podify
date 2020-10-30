using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Podcasts")]
    public class Podcast
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Interval { get; set; }
        public DateTime NextUpdate { get; set; }
        public List<Episode> Episodes { get; set; }
        public int TotalEpisodes { get; set; }

        public Podcast(string url, string name, string category, int interval, List<Episode> episodes)
        {
            Url = url;
            Name = name;
            Category = category;
            Interval = interval;
            Episodes = episodes;
            CountEpisodes();
        }

        public Podcast()
        {
        }

        private void CountEpisodes()
        {
            foreach (var i in Episodes)
            {
                TotalEpisodes++;
            }
        }

        public bool NeedsUpdate
        {
            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }

        public void Update()
        {
            NextUpdate = DateTime.Now.AddMinutes(Interval);
            XDocument urlDocument = new XDocument();

            {
                urlDocument = XDocument.Load(Url);
                Episodes = (from x in urlDocument.Descendants("item")
                            select new Episode
                            {
                                Name = x.Element("title").Value,
                                Description = x.Element("description").Value
                            }).ToList();
                Console.WriteLine("Next update is at " + NextUpdate);
                Console.WriteLine("Podcast: " + Name + " updated at " + DateTime.Now);
            };
            CountEpisodes();
        }
    }
}