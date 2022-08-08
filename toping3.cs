using System;

namespace recuperacion
{
        class toping3 : Decorador
    {
        public toping3(OrdenBase orden ) : base(orden)
        {

        }
        public override double CalculoPrecioPlato()
        {
            var H3 = base.CalculoPrecioPlato() + 0.50;
            return H3;
        }
    }
}