using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringNumbers
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            const string HelloWorldRus = "Я тебя люблю!!!";
            const string HelloWorldEn = "I love you!!!";
            const string HelloWorldEs = "Te amo!!!";

            var str = new[] { HelloWorldEn, HelloWorldRus, HelloWorldEs };
            var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();

            do
            {
                foreach (var strs in str)
                {
                    foreach (var word in strs)
                    {
                        var rnd = random.Next(list.Count());
                        Console.ForegroundColor = list[rnd];

                        Console.Write(word);
                        System.Threading.Thread.Sleep(150);
                    }

                    Console.WriteLine();
                }
            } while (true);
        }
    }
}
