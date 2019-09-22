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
           public void setPais(String pais){
          this.pais = pais;
        }
        public String getPais(){
            return this.pais;
        }

           public void setDirector(String director){
          this.director = director;
        }
        public String getDirector(){
            return this.director;
        }

        public Movie(){
          
        }
        public Movie(String info, Int16 año, String pais, String director){
          this.info = info;
          this.año = año;
          this.pais = pais;
          this.director = director;
        }
        public void imprime(){
          Console.WriteLine("info: {0}\naño: {1}\npais:{2}\ndirector:{3}\n", this.info, this.año,this.pais,this.director);
        }

  
        
     }
        
    
    class Program
    {
         
       static void Main(String[]args){

         // ----------(List)--------------
         Movie a = new Movie();
         a.setInfo("Tangamandapio");
         a.setAño(2019);
         a.setPais("México");
         a.setDirector("Jaimito el cartero");

         a.imprime();

         Movie b = new Movie();
         b.setInfo("SpiralMountain");
         b.setAño(2019);
         b.setPais("Noruega");
         b.setDirector("RareWare");

         b.imprime();

         List<Movie> movies = new List<Movie>();
          movies.Add(new Movie("CityEscape", 2000,"USA San francisco","Sonic Team"));
	        movies.Add(new Movie("Station Square",1998,"USA","Sonic Team" ));
	        movies.Add(new Movie("Living in the city ",1997,"USA","Traveller's Tales"));

         foreach(Movie p in movies){
           p.imprime();
         }
         // ----------(List)--------------


        // ----------(Private)------------ 
         //  Movie a;
         //  a = new Movie();
         //  Movie b = new Movie();
         //  a.setInfo("Tangamandapio");
         //  b.setInfo("La La Land");
         //  a.setAño(2019);
          // b.setAño(2000);

          // Console.WriteLine("-Pelicula 1-");
           // Console.WriteLine(a.getInfo());
          //  Console.WriteLine(a.getAño());
          // Console.WriteLine("-Pelicula 2-");
          //  Console.WriteLine(b.getInfo()); 
           // Console.WriteLine(b.getAño());

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