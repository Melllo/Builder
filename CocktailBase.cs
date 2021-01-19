using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    abstract class CocktailBase
    {
        protected Cocktail cocktail;

        protected CocktailBase() {
            cocktail = new Cocktail();

        }
        public Cocktail GetCocktail(){
            return cocktail;
        }

        public abstract void AddAlcohol();
        public abstract void AddJuice();
        public abstract void AddFruits();
        public abstract void AddSoda();
        public abstract void AddIce();
        public abstract void AddOther();
    }
}
