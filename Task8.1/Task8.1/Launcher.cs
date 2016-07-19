using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    class Launcher
    {
        static void Main(string[] args)
        {
            XMLWorker worker = new XMLWorker();
            ConsoleClass cons = new ConsoleClass();

            Catalog catalog = worker.Deserialize<Catalog>(Data.pathFromFile);
            worker.Serialize<Catalog>(catalog, Data.pathToFile);

            cons.ShowMessage();

            Console.ReadKey();
        }
    }
}
