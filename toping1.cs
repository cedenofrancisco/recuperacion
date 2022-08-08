using System;

namespace recuperacion
{
    class toping1 : Decorador
    {
        public toping1(OrdenBase orden ) : base(orden)
        {

        }
        public override double CalculoPrecioPlato()
        {
            var H1 = base.CalculoPrecioPlato() + 0.90;
            return H1;
        }
    }
}