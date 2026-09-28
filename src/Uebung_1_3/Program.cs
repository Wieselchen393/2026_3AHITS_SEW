// ------------------------------
// Uebung_1_3
// ------------------------------

namespace Uebung_1_3;

class Program
{
    static void Main(string[] args)
    {
        string[] name = { "Mayer", "Huber", "Gruber" };
        int[] punkte = { 21, 18, 15 };
        int Schueler = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{name[Schueler]} hat ein {getNote(punkte, Schueler)}");
            Schueler++;
        }
        Schueler = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{name[Schueler]} hat ein {getNoteText(punkte, Schueler)}");
            Schueler++;
        }
    }
    static int getNote(int[] punkte, int Schueler)
    {
        if (punkte[Schueler] >= 21)
        {
            return 1;
        }
        else if (punkte[Schueler] >= 18)
        {
            return 2;
        }
        else if (punkte[Schueler] >= 15)
        {
            return 3;
        }
        else if (punkte[Schueler] >= 12)
        {
            return 4;
        }
        else
        {
            return 5;
        }
    }
    static string getNoteText(int[] punkte, int Schueler)
    {
        if (punkte[Schueler] >= 21)
        {
            return "sehr gut";
        }
        else if (punkte[Schueler] >= 18)
        {
            return "gut";
        }
        else if (punkte[Schueler] >= 15)
        {
            return "befriedigend";
        }
        else if (punkte[Schueler] >= 12)
        {
            return "ausreichend";
        }
        else
        {
            return "nicht ausreichend";
        }
    }
}
