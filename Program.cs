using System;

namespace PovrsinaKruga
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<double, string> povrsinaKruga = r =>
            {
                double povrsina = Math.PI * r * r;
                return $"Površina kruga poluprečnika {r} je {povrsina:F2}.";
            };

            
            Console.WriteLine("Unesite poluprečnik kruga:");
            if (double.TryParse(Console.ReadLine(), out double poluprecnik))
            {
                string rezultat = povrsinaKruga(poluprecnik);
                Console.WriteLine(rezultat);
            }
            else
            {
                Console.WriteLine("Unet je nevažeći broj.");
            }

            Console.WriteLine("Pritisnite bilo koji taster za izlaz...");
            Console.ReadKey();
        }
    }
}

