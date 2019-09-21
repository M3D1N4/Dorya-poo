using System;
using System.Collections.Generic;

namespace Pelicula
{
    class Movie{
        private String info;
        private Int16 año;
        private String pais;
        private String director;
        
         public void setInfo(String info){
          this.info = info;
        }
        public String getInfo(){
            return this.info;
        }
          public void setAño(Int16 año){
          this.año = año;
        }
        public Int16 getAño(){
            return this.año;
        }
     }
        
    
    class Program
    {
         // ----------(Private)------------  
       static void Main(){
           Movie a;
           a = new Movie();
           Movie b = new Movie();
           a.setInfo("Tangamandapio");
           b.setInfo("La La Land");
           a.setAño(2019);
           b.setAño(2000);

           Console.WriteLine("-Pelicula 1-");
            Console.WriteLine(a.getInfo());
            Console.WriteLine(a.getAño());
           Console.WriteLine("-Pelicula 2-");
            Console.WriteLine(b.getInfo()); 
            Console.WriteLine(b.getAño());
          // ----------(Private)------------  

       
          // ----------(Public)------------ 
          //{   
          // Movie a;
          //a = new Movie();
          // Movie b = new Movie();
          // a.titulo = "Tangamandapio";
          // a.año = 2019;

          //  b.titulo = "La La Land";
          // b.año = 2000;

          // Console.WriteLine("-Pelicula 1-");
          // Console.WriteLine("Titulo:" + a.titulo);
          // Console.WriteLine("Fecha:" + a.año);

          // Console.WriteLine("-Pelicula 1-");
          // Console.WriteLine("Titulo:" + b.titulo);
          // Console.WriteLine("Fecha:" + b.año);
          //}
          // ----------(Public)------------

        
    }
}
}