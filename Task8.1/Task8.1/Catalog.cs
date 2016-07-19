using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8._1
{
    [XmlRoot(Namespace = "http://library.by/catalog", ElementName = "catalog")]
    public class Catalog
    {
        [XmlAttribute(DataType = "date", AttributeName = "date")]
        public DateTime Date { get; set; }

        [XmlElement("book")]
        public Book[] books { set; get; }
    }
}
