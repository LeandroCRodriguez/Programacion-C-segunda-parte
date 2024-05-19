﻿using Centralita;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");
            

            // Mis 4 llamadas
            Local l1 = new Local(30, "Bernal", "Rosario",2.65f);
            Provincial l2 = new Provincial(21, "Morón",  "Bernal", EFranja.Franja1);
            Local l3 = new Local(45, "Lanús",  "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2, EFranja.Franja3);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}