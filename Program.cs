using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {  Console.WriteLine("enter the value of x and y");
             int x=Convert.ToInt32(Console.ReadLine());
             int y=Convert.ToInt32(Console.ReadLine());
             int sum=x+y;
            Console.WriteLine(sum);
            
           
        }
    }
}