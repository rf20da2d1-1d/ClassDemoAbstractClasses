using System;

namespace ClassDemoAbstractClasses
{
    public class FigurWorker
    {
        public FigurWorker()
        {
        }

        public void Start()
        {
            Trekant tre = new Trekant(10, 4);
            Cirkel cirk = new Cirkel(4);


            Console.WriteLine(tre);
            Console.WriteLine("areal = " + tre.GetAreal());
            Console.WriteLine(cirk);
            Console.WriteLine("areal = " + cirk.GetAreal());

            Figur fig = new Trekant(10, 4);
            Console.WriteLine(fig.GetAreal());
            fig.UdskrivAreal();

        }
    }
}