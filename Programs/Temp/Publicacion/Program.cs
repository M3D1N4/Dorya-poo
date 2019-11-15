  
using System;
using System.Collections.Generic;

namespace Publicacion
{
    abstract class Publicacion{
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
     public abstract void Print();
    }

    class Estado:Publicacion{
      public Estado(string N,string M,string A,string C,string L):base(N,M,A,C,L)
        {
          
        }
        public override void Print()
        {
              Console.WriteLine("By: {0} \n Message :{1} \n Reacts: {2}\n Comments : {3}\n Link {4} \n (status)Les deseo Felices fiestas\n",Nombre,Mensaje,amigo,comentario,link);
   
        }
    }
    class Fotos{
    }
    class Link{

    }

    class Program
    {
        static void Main(string[] args)
        {
          var X = new Estado("Jorge Nitales","Ami me wusta el tangananica","1 DisLike","Se escribe con g.","feisbuk.com");
           X.Print();
        }
    }
}