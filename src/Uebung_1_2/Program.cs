// ------------------------------
// Uebung_1_2
// ------------------------------

namespace Uebung_1_2;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        while (i <= 100)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}
