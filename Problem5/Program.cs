using System;

namespace Problem5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            int result = N / 60;

            Console.WriteLine($"result = {result}");
        }
    }
}
