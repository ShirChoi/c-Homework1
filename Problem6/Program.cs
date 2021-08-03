using System;

namespace Problem5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            int result = K % 7;

            Console.WriteLine($"result = {result}");
        }
    }
}
