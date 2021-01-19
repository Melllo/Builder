using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class PinaColada : CocktailBase
    {
        public PinaColada():base() {}
        public override void AddAlcohol()
        {
            cocktail.Alcohol = "Светлый ром";
        }

        public override void AddFruits()
        {
            cocktail.Fruits = "Вишенка";
        }

        public override void AddIce()
        {
            cocktail.Ice = "Да";
        }

        public override void AddJuice()
        {
            cocktail.Juice = "Ананасовый сок";
        }

        public override void AddOther()
        {
            Console.WriteLine("Enter additional ingredient: ");
            string s = Console.ReadLine();
            cocktail.Other = s;
        }

        public override void AddSoda()
        {
            cocktail.Soda = "Кокосовое молоко";
        }
    }
}
