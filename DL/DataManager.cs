using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DL
{
    public class DataManager
    {
        public static void WriteXML()
        {
            string path = @"podcasts.xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create(path, settings);
        }

        public static List<Podcast> Deserialize()
        {
            List<Podcast> podcastList;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                FileAccess.Read))
            {
                podcastList = (List<Podcast>)xmlSerializer.Deserialize(inFile);
            }
            return podcastList;
        }
    }
}