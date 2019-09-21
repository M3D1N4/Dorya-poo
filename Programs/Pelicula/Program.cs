using System;
using System.Collections.Generic;

namespace Pelicula
{
    class Movie{
        public String titulo;
        public Int16 año;
        public String pais;
        public String director;}
    
    class Program
    {

        static void Main()
        { 
           Movie a;
           a = new Movie();
           Movie b = new Movie();
           a.titulo = "Tangamandapio";
           a.año = 2019;

            b.titulo = "La La Land";
           b.año = 2000;

           Console.WriteLine("-Pelicula 1-");
           Console.WriteLine("Titulo:" + a.titulo);
           Console.WriteLine("Fecha:" + a.año);

           Console.WriteLine("-Pelicula 1-");
           Console.WriteLine("Titulo:" + b.titulo);
           Console.WriteLine("Fecha:" + b.año);



          //  Pelicula p1 = new Pelicula();
            //p1.SetTitulo("La La Land");
            //p1.SetAño(2016); 
            //Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
