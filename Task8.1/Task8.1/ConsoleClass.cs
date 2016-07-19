using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    class ConsoleClass
    {
        public void ShowSerializeMessage()
        {
            Console.WriteLine($"File serialized.Path to file :{Data.pathToFile}");
        }


        public void ShowCatolog(Catalog catalog)
        {
            Console.WriteLine(catalog);
        }

        public bool Cases()
        {
            Console.WriteLine("Do yoy want serialize file? (yes/no)");
            string choose = Console.ReadLine();
            if (choose == "yes")
            {
                return true;
            }
            return false;
        }


        public void MessageForExit()
        {
            Console.WriteLine("Please,press any key for exit");
        }
    }
}
