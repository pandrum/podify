using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DL
{
    public class DataManager
    {
        public void Serialize(List<Podcast> podcastList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(podcastList.GetType());
            using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Append, FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, podcastList);
                MessageBox.Show("Podcast successfully added to your feed!");
            }
        }

        public List<Podcast> Deserialize()
        {
            try
            {
                List<Podcast> podcastListReturn;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    podcastListReturn = (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
                return podcastListReturn;
            }
            catch (Exception)
            {
                Console.WriteLine("No XML-file found.");
            }
            return null;
        }
    }
}