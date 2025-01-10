using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fun
{
    internal class PrintClass
    {
        private string language = "";

        // Constructor (only run once)
        public PrintClass()
        {
            language = "EN";
        }
        public PrintClass (string langHolder)
        {
            language = langHolder;
        }
        public void PrintName(string username)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + username);
            }

            if (language == "SW")
            {
                System.Console.WriteLine("Niaje, " + username + " unaongea Kiswahili?");
            }
            

        }
    }
}
