  
using System;
using System.Collections.Generic;

namespace Publicacion
{
    abstract class Publicacion{
       protected string Nombre;
       protected string Mensaje;
       protected string Amigo;
       protected string Comentario;
       protected string Link;
       
       public Publicacion(string N,string M,string A,string C,string L)
       {
           this.Nombre = N;
           this.Mensaje = M;
           this.Amigo = A;
           this.Comentario = C;
           this.Link = L;
       }
     public abstract void Print();
    }

    class Estado:Publicacion{
      public Estado(string N,string M,string A,string C,string L):base(N,M,A,C,L){
          
        }
        public override void Print(){
              Console.WriteLine("By: {0} \n Message :{1} \n Reacts: {2}\n Comments : {3}\n Link {4} \n (status)Les deseo Felices fiestas\n",Nombre,Mensaje,Amigo,Comentario,Link);
   
        }
    }
    class Fotos:Publicacion{
        public Fotos(string N,string M,string A,string C,string L):base(N,M,A,C,L){
            
        }
        public override void Print(){
           Console.WriteLine("By: {0} \n Message :{1} \n Reacts: {2}\n Comments : {3}\n Link {4} \n (status)Desperdiciando oxigeno\n",Nombre,Mensaje,Amigo,Comentario,Link);
        }
    }
    class Link{

    }

    class Program{
        static void Main(string[] args){
          var X = new Estado("Jorge Nitales","Ami me wusta el tangananica","1 DisLike","Se escribe con g.","www.feisbuk.com");
           X.Print();
           var Y = new Estado("Carlos Santoyo","Solo quiero demostrar que todos estan equivocados y yo tengo razón."," 27 Likes, 500 DisLike","Exclamo la princesa.","www.Cara-libro.com");
           Y.Print();
        }
    }
}