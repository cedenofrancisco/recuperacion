using System;

namespace recuperacion
{
    public class Program
    {
        public static void Main(string []args)
        {
            Console.WriteLine();
            Console.WriteLine("Burrito: ");
            var C1 = new Burrito();
            var T1 = new toping1(C1);
            var T2 = new toping1(T1);
            var T3 = new toping3(T2);
            var T4 = new toping4(T3);
            Console.WriteLine("El precio del burrito sin toping es de: $");
            Console.WriteLine(C1.CalculoPrecioPlato());
            Console.Write("El precio Total del Burrito con ingredientes adicionales es de: $");
            Console.WriteLine(T3.CalculoPrecioPlato());
            Console.WriteLine();

            Console.WriteLine("Tacos: ");
            var C2 = new tacos();
            var T5 = new toping1(C2);
            var T6 = new toping2(T5);
            var T7 = new toping3(T6);
            var T8 = new toping4(T7);
            Console.WriteLine("El precio del Taco sin toping es de: $");
            Console.WriteLine(C2.CalculoPrecioPlato());
            Console.Write("El precio Total del Taco con ingredientes adicionales es de: $");
            Console.WriteLine(T6.CalculoPrecioPlato());
            Console.WriteLine();

            Console.WriteLine("Tamales :");
            var C3 = new tamales();
            var T9 = new toping1(C3);
            var T10 = new toping2(T9);
            var T11 = new toping3(T10);
            var T12 = new toping4(T11);
            Console.WriteLine("El precio del Tamal sin toping es de: $");
            Console.WriteLine(C3.CalculoPrecioPlato());
            Console.WriteLine("El precio Total del Tamal con ingredientes adicionales es de: $");
            Console.WriteLine(T9.CalculoPrecioPlato());
            Console.WriteLine();
        }
    }
}