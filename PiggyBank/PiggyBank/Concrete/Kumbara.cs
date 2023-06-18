using PiggyBank.Interface;
using System;

namespace PiggyBank.Concrete
{
    public class Kumbara : ISalla
    {
        public Kumbara(int hacim)
        {
            KumbaraHacmi = hacim;
        }
        public double KumbaraHacmi { get; set; }
        public double Salla(double fazladanKaplananHacim)
        {
            Random rnd = new Random();
            return fazladanKaplananHacim * rnd.Next(25, 76) * 0.01;
        }
        public double ToplamParaHacim { get; set; }
        public void ParaEkle(double miktar)
        {
            ToplamParaHacim += miktar;
        }
    }
}
