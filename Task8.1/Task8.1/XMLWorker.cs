using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8._1
{
    class XMLWorker
    {
        public T Deserialize<T>(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            Stream reader = new FileStream(path, FileMode.Open);

            T catalog = (T)xs.Deserialize(reader);

            reader.Close();
            return catalog;
        }

        public void Serialize<T>(T obj, string pathToFile)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", Data.namespaces);
            XmlSerializer xs = new XmlSerializer(typeof(T));

            // Запись
            var writer = new StreamWriter(pathToFile, false, System.Text.Encoding.UTF8);
            xs.Serialize(writer, obj, ns);
            writer.Close();
        }
    }
}
