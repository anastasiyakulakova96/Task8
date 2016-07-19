using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8._1
{
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date", DataType = "date")]
        public DateTime Publish_date { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date", DataType = "date")]
        public DateTime Registration_date { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Id: " + Id);
            result.AppendLine("Isbn: " + Isbn);
            result.AppendLine("Author: " + Author);
            result.AppendLine("Title: " + Title);
            result.AppendLine("Genre: " + Genre);
            result.AppendLine("Publisher: " + Publisher);
            result.AppendLine("Publish_date: " + Publish_date);
            result.AppendLine("Description: " + Description);
            result.AppendLine("Registration_date: " + Registration_date);
            result.AppendLine("------------------------------------------");

            return result.ToString();
        }
    }
}
