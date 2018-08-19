using Collections;
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
            ArrayList arrList = new ArrayList();

            arrList.Add(20);
            arrList.Add(70);
            arrList.Add("End");

            arrList.Insert(2, 5000);





            for (int i = 0; i <arrList.length ; i++)
            {
                Console.WriteLine(arrList.Read(i));
            }

            Console.Read();

        }
    }
}
