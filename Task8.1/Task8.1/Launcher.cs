using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8._1
{
    class Launcher
    {
        //private static object formatter;

        static void Main(string[] args)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(BookId));

            //// получаем поток, куда будем записывать сериализованный объект
            //using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, person);

            //    Console.WriteLine("Объект сериализован");
            //}

            using (FileStream fs = new FileStream("Books.xml", FileMode.OpenOrCreate))
            {
                BookId newBook = (BookId)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1}", newBook.Isbn, newBook.Author);
            }
        }
    }


    [Serializable]
    public class BookId
    {
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string Publisher_data { get; set; }
        public string Description { get; set; }


        // стандартный конструктор без параметров
        public BookId()
        { }

        public BookId(string isbn, string author, string title, string genre, string publisher, string publisher_data,string description)
        {
            Isbn = isbn;
            Author = author;
            Title = title;
            Genre = genre;
            Publisher = publisher;
            Publisher_data = publisher_data;
            Description = description;
        }
    }
}
