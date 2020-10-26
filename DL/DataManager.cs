using Model;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DL
{
    public class DataManager
    {
        private string path = @"Podcasts.xml";
        private List<Podcast> podcastList;

        public void Serialize(List<Podcast> podcastList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(podcastList.GetType());
            using (FileStream outFile = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, podcastList);
            }
        }

        public List<Podcast> Deserialize()
        {
            if (File.Exists(path))
            {
                List<Podcast> podcastList;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream(path, FileMode.Open,
                    FileAccess.Read))
                {
                    podcastList = (List<Podcast>)xmlSerializer.Deserialize(inFile);
                    return podcastList;
                }
            }
            return podcastList;
        }
    }
}