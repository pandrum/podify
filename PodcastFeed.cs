using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutomateEverything
{
    internal class PodcastFeed
    {
        public PodcastFeed()
        {
            //Test
        }

        public static void Test()
        {
            XmlReader reader = XmlReader.Create("https://feed.pod.space/alexosigge");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (var item in feed.Items)
            {
                Console.WriteLine(item.Title.Text);
                Console.ReadLine();
            }
        }
    }
}