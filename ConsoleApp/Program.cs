using Collections;
using System;

namespace ConsoleApp2
{
    class Program
    {

      public  static void Main(string[] args)
        {
            //ArrayList arrList=new ArrayList();

            ////adding some items
            //arrList.Add(20);
            //arrList.Add(30);
            //arrList.Add(40);
            //arrList.Add(50);
            //arrList.Add("End");
            ////insert item in specific index
            //arrList.Insert(2, 5000);
            //Console.WriteLine("Original Array\n");
            ////print all items
            //arrList.PrintItems();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("New Array\n");
            ////remove item at specific index
            //arrList.RemoveAt(5);
            //arrList.ReplaceWith(0,7000);
            ////print all items
            //arrList.PrintItems();
            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine($"index of {30} is {arrList.IndexOf(30)}");
            //Console.WriteLine($"index of {50} is {arrList.IndexOf(50)}");
            //Console.WriteLine($"index of End is {arrList.IndexOf("End")}");
            //Console.Read();

            GenericArrayList<int> genericArrayList = new GenericArrayList<int>();

            genericArrayList.Add(5);
            genericArrayList.Add(1);

            int sum = genericArrayList.GetItem(0) + genericArrayList.GetItem(1);
            Console.WriteLine("Sum is {0}",sum);
            Console.Read();


        }
    }
}
