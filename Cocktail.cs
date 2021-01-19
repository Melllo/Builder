using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Cocktail
    {
        public string Alcohol { get; set; }
        public string Juice { get; set; }
        public string Soda { get; set; }
        public string Fruits { get; set; }
        public string Ice { get; set; }
        public string Other { get; set; }

        public override string ToString()
        {
            string cc = "Alcohol: " + Alcohol +
                "\nJuice: " + Juice +
                "\nSoda: " + Soda +
                "\nFruits: " + Fruits +
                "\nIce: " + Ice +
                "\nOther: " + Other;
            return cc;
        }
    }
}
