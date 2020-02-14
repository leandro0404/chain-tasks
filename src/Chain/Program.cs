using System;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new Context();
            context.Database.EnsureCreated();

            Console.WriteLine("Hello World!");
        }
    }

}
