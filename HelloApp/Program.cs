using System;

namespace HelloApp
{
    public class Program
    {
        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
            var a = true;
            if (a == true)
            {
                return;
            }
            else if (a == false)
            {
                return;
            }
            else
            {
                return;
            }
        }

        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        //обсудили)))
        
        public static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
        }
    }
}