using System;

namespace recuperacion
{
        class toping4 : Decorador
    {
        public toping4(OrdenBase orden ) : base(orden)
        {

        }
        public override double CalculoPrecioPlato()
        {
            var H4 = base.CalculoPrecioPlato() + 0.60;
            return H4;
        }
    }
}