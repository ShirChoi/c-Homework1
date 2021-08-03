using System;

namespace Problem3 {
    class Program {
        static void Main(string[] args) {
            double x1 = Read("x1"), y1 = Read("y1");
            double x2 = Read("x2"), y2 = Read("y2");

            double dx = Math.Abs(x1 - x2);
            double dy = Math.Abs(y1 - y2);

            double result = Math.Sqrt(dx * dx + dy * dy);

            Console.WriteLine($"result = {result}");
        }

        static double Read(string varName) {
            Console.Write(varName + " = ");
            return double.Parse(Console.ReadLine());
        } 
    }
}
