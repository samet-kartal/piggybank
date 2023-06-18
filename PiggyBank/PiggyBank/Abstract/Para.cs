using System;

namespace PiggyBank.Abstract
{
    public abstract class Para
    {
        public string Ad { get; set; }
        public double Deger { get; set; }
        public abstract double Hacim();
        public double ToplamHacim()
        {
            Random rnd = new Random();
            return (rnd.Next(25, 76) * Hacim()) / 100;
        }
    }
}
