using System;

namespace recuperacion
{
    public class Decorador : OrdenBase
    {
        protected OrdenBase orden;

        public Decorador (OrdenBase orden)
        {
            this.orden = orden;
        }
        public override double CalculoPrecioPlato()
        {
            return orden.CalculoPrecioPlato();
        }
    }
}