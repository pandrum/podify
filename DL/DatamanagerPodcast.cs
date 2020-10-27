using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace DL
{
    public class DatamanagerPodcast
    {
        public void Serialize(List<Podcast> podcastList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(podcastList.GetType());
            using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, podcastList);
            }
        }

        public List<Podcast> Deserialize()
        {
            List<Podcast> podcastList = new List<Podcast>();
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    podcastList = (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No list to fetch.");
            }
            return podcastList;
        }
    }
}