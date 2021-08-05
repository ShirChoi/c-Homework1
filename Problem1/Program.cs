using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            double a = Read("a");
            double b = Read("b");

            System.Console.WriteLine($"Result = {Math.Sqrt(a * b)}");
        }

        static double Read(string varName) {
            Console.Write(varName + " = ");
            return double.Parse(Console.ReadLine());
        } 
    }
}