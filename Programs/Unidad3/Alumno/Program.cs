using System;
using System.Collections.Generic;

namespace Alumno
{
    class Alumno{
        protected string Nombre;
        public Alumno(string A)
        {
            Nombre = A;
        }
     public virtual void Presente(){
         Console.WriteLine("Hola, soy {0}",Nombre);
     }
     public virtual void Accion(){
            Console.WriteLine("{0}, lel {0}",Nombre);
        }
    }
    class Licenciatura:Alumno{
        private string Lice;
         public Licenciatura(string no,string L):base(no)
            {
                this.Lice=L;
            }
            public override void Accion(){
                Console.WriteLine("Estoy en una Licenciatura y debo Prepararme para mi {1}",Nombre,Lice);
            }

    }
    class Posgrado:Alumno{
       private string Pos;
         public Posgrado(string no,string P):base(no)
            {
                this.Pos=P;
            }
            public override void Accion(){
                Console.WriteLine("Estoy en Posgrado y debo realizar mi {1}",Nombre,Pos);
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Tomas=new Alumno("x");
            Licenciatura flea=new Licenciatura("Luna","Residencia y Servicio social.");
            Posgrado Poss=new Posgrado("Emily","Investigacion.");
            List <Alumno> grupo = new List <Alumno>();
            grupo.Add(flea);
            grupo.Add(Poss);
            foreach(Alumno m in grupo){
                m.Presente();
                m.Accion();
                Console.WriteLine(" ");
        }
    }
}
}
