using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want? (1 - Pina Colada, 2 - Mojito, 3 - BlueLagoone)");
            string s = Console.ReadLine();
            if (s.Equals("1")) {
                var coctailBuilder = new PinaColada();
                coctailBuilder.AddAlcohol();
                coctailBuilder.AddFruits();
                coctailBuilder.AddIce();
                coctailBuilder.AddSoda();
                coctailBuilder.AddJuice();
                Console.WriteLine("Do you want something extra?");
                coctailBuilder.AddOther();
                var coctail = coctailBuilder.GetCocktail();
                Console.WriteLine(coctail);
            } else 
            if (s.Equals("2")) {
                var coctailBuilder = new Mojito();
                coctailBuilder.AddAlcohol();
                coctailBuilder.AddFruits();
                coctailBuilder.AddIce();
                coctailBuilder.AddJuice();
                Console.WriteLine("Do you want something extra?");
                coctailBuilder.AddOther();
                var coctail = coctailBuilder.GetCocktail();
                Console.WriteLine(coctail);
            }
            else 
            if (s.Equals("3")) {
                var coctailBuilder = new BlueLagoone();
                coctailBuilder.AddAlcohol();
                coctailBuilder.AddFruits();
                coctailBuilder.AddIce();
                coctailBuilder.AddSoda();
                coctailBuilder.AddJuice();
                Console.WriteLine("Do you want something extra?");
                coctailBuilder.AddOther();
                var coctail = coctailBuilder.GetCocktail();
                Console.WriteLine(coctail);
            }
        }
    }
}
