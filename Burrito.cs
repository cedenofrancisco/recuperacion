using System;

namespace recuperacion
{
    public class Burrito : OrdenBase
    {
        public override double CalculoPrecioPlato()
        {
            var P2 = 2.60;
            return P2;
        }
    }
}