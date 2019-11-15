  
using System;
using System.Collections.Generic;

namespace Publicacion
{
    abstract class Publicacion
    {
       
       protected string Nombre;
       protected string Mensaje;
       protected string amigo;
       protected string comentario;
       protected string link;
       
       public Publicacion(string N,string M,string A,string C,string L)
       {
           this.Nombre = N;
           this.Mensaje = M;
           this.amigo = A;
           this.comentario = C;
           this.link = L;
       }
 
    }

    class Estado{
      
    }
    class Fotos{
    }
    class Link{

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}