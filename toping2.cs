using System;

namespace recuperacion
{
        class toping2 : Decorador
    {
        public toping2(OrdenBase orden ) : base(orden)
        {

        }
        public override double CalculoPrecioPlato()
        {
            var H2 = base.CalculoPrecioPlato() + 0.80;
            return H2;
        }
    }
}