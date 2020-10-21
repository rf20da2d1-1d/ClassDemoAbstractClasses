using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoAbstractClasses
{
    public class Trekant:Figur
    {
        private int _grundlinje;
        private int _højde;

        public int Grundlinje => _grundlinje;

        public int Højde => _højde;

        public Trekant(int grundlinje, int højde)
        {
            _grundlinje = grundlinje;
            _højde = højde;
        }

        public override double GetAreal()
        {
            return _grundlinje * _højde / 2.0;
        }

        public override string ToString()
        {
            return $"{nameof(Grundlinje)}: {Grundlinje}, {nameof(Højde)}: {Højde}";
        }

        



    }
}
