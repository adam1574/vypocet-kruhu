using System;

namespace vypocet_kruhu
{
    class Program
    {
        static void Main(string[] args)
        {
            double polomer;
            double obsah;
            double obvod;
            double prumer = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("obsah a obvod kruhu");
                Console.Write("zadej poloměr: ");
                double.TryParse(Console.ReadLine(), out polomer);
                if (polomer <= 0)
                {
                    Console.Write("zadej prumer: ");
                    double.TryParse(Console.ReadLine(), out prumer);
                }

                else
                {
                    obvod = 2 * 3.14 * polomer;
                    Console.WriteLine("____________________________");
                    Console.WriteLine($"výpočet obvodu je {obvod}");
                    obsah = 3.14 * (polomer * polomer);
                    Console.WriteLine($"výpočet obsahu je {obsah}");
                }

                if (polomer > 0)
                {
                    Console.Write("zadej prumer: ");
                    double.TryParse(Console.ReadLine(), out prumer);
                }
                else
                {
                    obvod = 3.14 * prumer;
                    Console.WriteLine("____________________________");
                    Console.WriteLine($"výpočet obvodu je {obvod}");
                    obsah = 3.14 * (prumer * prumer) / 4;
                    Console.WriteLine($"výpočet obsahu je {obsah}");
                }


                Console.ReadLine();
            }
               
        }
    }
}
