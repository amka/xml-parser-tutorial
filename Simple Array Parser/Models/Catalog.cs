using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace XML_Parser.Models
{
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlElement(ElementName = "book")]
        public List<Book> Books { get; set; }
        
        public override string ToString()
        {
            return $"<{nameof(Catalog)}:{nameof(Books)}={Books.Count}>";
        }
    }
}