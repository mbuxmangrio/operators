namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = 20;
            var v2 = 10;
            int result = v1 + v2;
            Console.WriteLine($"Addition (+) : {result}");
            result = v1 - v2;
            Console.WriteLine($"Substraction (-) :{result}");
            result = v1 * v2;
            Console.WriteLine($"Multiplication (*) :{result}");
            result = v1 / v2;
            Console.WriteLine($"Division (/) :{result}");
            result = v1 % v2;
            Console.WriteLine($"Modulo (%) :{result}");
            var number = 50;
            Console.WriteLine($"Actual number variable :{number}");
            Console.WriteLine($"Update number variable:{++number}");
            Console.WriteLine($"Update number variable:{number++}");
            Console.WriteLine($"Update number variable:{--number}");
            Console.WriteLine($"Update number variable:{number--}");




            var val1 = 20;
            var val2 = 10;

             val1 += val2;
            Console.WriteLine($"Addition assignment:{val1}");
            val1 -= val2;
            Console.WriteLine($"Substraction assignment:{val1}");
            val1 *= val2;
            Console.WriteLine($"Multiplication assignment:{val1}");
            val1 /= val2;
            Console.WriteLine($"Division assignment:{val1}");
            val1 %= val2;
            Console.WriteLine($"Modulo assignment :{val1}");



            val1 += 5;















        }
    }
}