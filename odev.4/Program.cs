using System;

class Program
{
    static void Main(string[] args)
    {
        int toplam = 0;
        int sayi;

        while (true)
        {
            Console.Write("Bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 83)
            {
                break;
            }

            toplam += sayi;
        }

        Console.WriteLine("Toplam = " + toplam);
    }
}
