using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BlueLagoone : CocktailBase
    {
        public BlueLagoone() : base() { }
        public override void AddAlcohol()
        {
            cocktail.Alcohol = "Водка, ликер";
        }

        public override void AddFruits()
        {
            cocktail.Fruits = "Ананас или лимон";
        }

        public override void AddIce()
        {
            cocktail.Ice = "Да";
        }

        public override void AddJuice()
        {
            cocktail.Juice = "";
        }

        public override void AddOther()
        {
            Console.WriteLine("Enter additional ingredient: ");
            string s = Console.ReadLine();
            cocktail.Other += s;
        }

        public override void AddSoda()
        {
            cocktail.Soda = "Спрайт";
        }
    }
}
