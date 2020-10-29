using System;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Episodes")]
    public class Episode
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Episode()
        {
        }
    }
}