using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using XML_Parser.Models;

namespace XML_Parser
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Path to XML file
            var simpleDocPath = Path.Combine("SimpleDocument.xml");
            
            // Create serializer
            var serializer = new XmlSerializer(typeof(Catalog));
            
            // Open file to read
            using var stream = new FileStream(simpleDocPath, FileMode.Open);
            
            // Deserialize XML to Catalog class
            var catalog = (Catalog) serializer.Deserialize(stream);
            
            // Print for the sake of the visibility
            Console.WriteLine(catalog);
            catalog.Books.ForEach(b =>
            {
                Console.WriteLine($"{b.Title} - {b.Author}");
                Console.WriteLine($" - {"Id", -15}: {b.Id}");
                Console.WriteLine($" - {"Genre", -15}: {b.Genre}");
                Console.WriteLine($" - {"PublishDate", -15}: {b.PublishDate}");
                Console.WriteLine($" - {"Price", -15}: {b.Price}");
                Console.WriteLine($" - {"Description", -15}: {b.Description}");
            });
        }
    }
}