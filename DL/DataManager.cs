using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DL
{
    public class DataManager
    {
        public DataManager()
        {
        }

        public static void Test()
        {
            XmlReader reader = XmlReader.Create("http://joeroganexp.joerogan.libsynpro.com/rss");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (var item in feed.Items)
            {
                string title = item.Title.Text;
                Console.WriteLine(title);

                var description = item.Summary.Text;
                Console.WriteLine(description);
                Console.ReadLine();
            }
        }

        public static void WriteXML()
        {
            string path = @"C:\C:\temp\test.xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create(path, settings);
        }
    }
}