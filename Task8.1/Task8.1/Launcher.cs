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
            ConsoleClass cons = new ConsoleClass();
            Controller controller = new Controller();

            Catalog catalog = controller.CheckSerialize();

            cons.ShowCatolog(catalog);

            if (catalog != null && cons.Cases())
            {
                controller.CheckDeserialize();
                cons.ShowSerializeMessage();
            }

            cons.MessageForExit();

            Console.ReadKey();
        }
    }
}
