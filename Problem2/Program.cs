using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("A = ");
            double A = double.Parse(Console.ReadLine());
            
            Console.Write("B = ");
            double B = double.Parse(Console.ReadLine());
            
            Console.Write("C = ");
            double C = double.Parse(Console.ReadLine());

            double AC = Math.Abs(A - C);
            Console.WriteLine($"AC = {AC}");

            double BC = Math.Abs(B - C);
            Console.WriteLine($"BC = {BC}");

            Console.WriteLine($"AC+BC = {AC + BC}");

        }
    }
}
