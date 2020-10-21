using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoAbstractClasses
{
    public abstract class Figur:IFigur
    {
        public abstract double GetAreal();

        public void UdskrivAreal()
        {
            Console.WriteLine("Arealet er " + GetAreal());
        }

    }
}
