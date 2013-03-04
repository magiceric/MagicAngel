using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicAngel
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCommand = "";
            //Console.WriteLine("Hello world!");
            
            Core_Mind coreMind = new Core_Mind();
            Core_Interface coreInterface = new Core_Interface();
            Core_Memory coreMemory = new Core_Memory();

            while (!strCommand.Equals("quit"))
            {
                Console.Write("# ");
                strCommand = Console.ReadLine();
                Console.WriteLine(strCommand);
            }
        }
    }
}
