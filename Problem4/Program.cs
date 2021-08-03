using System;

namespace Problem4 {
    class Program {
        static void Main(string[] args) {
            /*
            string val = Console.ReadLine();

            Console.WriteLine($"result = {val[1]}{val[0]}");
            */

            Console.Write("Value = ");
            int val = int.Parse(Console.ReadLine());

            int result = (val % 10) * 10 + val / 10;

            Console.WriteLine($"result = {result}");
        }
    }
}
