using System;
using System.Xml.Serialization;

namespace XML_Parser.Models
{
    [XmlRoot("book")]
    public class Book
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        
        [XmlElement("author")]
        public string Author { get; set; }
        
        [XmlElement("title")]
        public string Title { get; set; }
        
        [XmlElement("genre")]
        public string Genre { get; set; }

        [XmlElement("price")]
        public float Price { get; set; }

        [XmlElement(ElementName = "publish_date")]
        public DateTime PublishDate { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"<{nameof(Book)}:Id={Id} Author={Author}; Title={Title}; Genre={Genre}; PublishDate={PublishDate}; Price={Price}>";
        }
    }
}