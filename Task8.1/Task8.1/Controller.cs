using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    class Controller
    {
        XMLWorker worker = new XMLWorker();
 Catalog catalog = null;

        public Catalog CheckSerialize()
        {
           
            try
            {
                catalog = worker.Deserialize<Catalog>(Data.pathFromFile);
                worker.Serialize<Catalog>(catalog, Data.pathToFile);
            }

            catch (Exception e)
            {
                Console.WriteLine("exception: " + e.Message);

            }
            return catalog;
        }


        public void CheckDeserialize()
        {
            try
            {
                worker.Serialize<Catalog>(catalog, Data.pathToFile);
            }

            catch (Exception e)
            {
                Console.WriteLine("exception: " + e.Message);

            }
        }


    }
}
