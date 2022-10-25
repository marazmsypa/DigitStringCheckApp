using StringCheckLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCheck testedObj = new StringCheck();
            List<char> list = testedObj.GetDigit("123456789");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
