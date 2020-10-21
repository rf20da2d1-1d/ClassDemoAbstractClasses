using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoAbstractClasses
{
    public class Cirkel:Figur
    {
        private int _radius;

        public int Radius => _radius;

        public Cirkel(int radius)
        {
            _radius = radius;
        }

        public override double GetAreal()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override string ToString()
        {
            return $"{nameof(Radius)}: {Radius}";
        }
    }
}
