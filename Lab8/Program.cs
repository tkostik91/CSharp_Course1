using System.Numerics;

namespace Lab8
{
    internal class Program
    {
        static void Factorial(int n)
        {
            BigInteger res = 1;
            BigInteger i = 1;
            try
            {
                checked
                {
                    for (; i <= n; i++)
                    {

                        res *= i;

                    }
                }
            }
            catch (OverflowException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine($"Максимальное значение допустимо для {i}!");
                
            }

            Console.WriteLine($"Факториал {i}! = {res}");
        }
        static void Main(string[] args)
        {
            int n = 100;

            Factorial(n);

        }
    }
}

