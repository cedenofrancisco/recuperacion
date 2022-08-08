using System;

namespace recuperacion
{
    public class tacos : OrdenBase
    {
        public override double CalculoPrecioPlato()
        {
            var P1 = 4.70;
            return P1;
        }
    }
}