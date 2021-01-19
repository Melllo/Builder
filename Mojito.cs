using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Mojito : CocktailBase
    {
        public Mojito() : base() { }
        public override void AddAlcohol()
        {
            cocktail.Alcohol = "Светлый ром";
        }

        public override void AddFruits()
        {
            cocktail.Fruits = "Лайм, мята";
        }

        public override void AddIce()
        {
            cocktail.Ice = "Да";
        }

        public override void AddJuice()
        {
            cocktail.Juice = "Сок лайма";
        }

        public override void AddOther()
        {
            Console.WriteLine("Enter additional ingredient: ");
            string s = Console.ReadLine();
            cocktail.Other += s;
        }

        public override void AddSoda()
        {
            cocktail.Soda = "";
        }
    }
}
