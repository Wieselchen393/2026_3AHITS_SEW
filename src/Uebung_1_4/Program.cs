// ------------------------------
// Uebung_1_4
// ------------------------------

namespace Uebung_1_4;

class Program
{
    static void Main(string[] args)
    {
        int Wert = 2;
        Console.WriteLine(fakulaet(5));
    }
    static int fakulaet(int Wert)
    {
        int Erg = 1;
        int temp = 1;
        while (temp <= Wert)
        {
            Erg = Erg * temp;
            temp++;
        }
        return Erg;
    }
}
