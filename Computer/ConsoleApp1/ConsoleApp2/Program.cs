using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tools.GetMacAddress());
            Console.WriteLine("----------------------");
            Console.WriteLine(Tools.getMacAddr_Local().Replace("-",""));
            Console.ReadLine();
        }
    }
}
