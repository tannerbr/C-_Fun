using System.Xml.Linq;
using C__Fun;
internal class Program
{
    private static void Main(string[] args) {
        string name = "";

        PrintClass printc = new PrintClass("SW");

        System.Console.WriteLine("Please Enter Your Name: ");
        name = System.Console.ReadLine();

        printc.PrintName(name);

    }
}