﻿using System;
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
        }

        public static void Test()
        {
            XmlReader reader = XmlReader.Create("https://rss.art19.com/impaulsive-with-logan-paul");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (var item in feed.Items)
            {
                Console.WriteLine(item.Title.Text);
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