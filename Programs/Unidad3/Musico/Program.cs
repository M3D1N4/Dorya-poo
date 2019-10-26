using System;
using System.Collections.Generic;


namespace Musico
{
    class Musico{
        protected string Nombre;
        public Musico(string N)
        {
            Nombre = N;
        }

        public virtual void Saludar(){
            Console.WriteLine("Hola, soy {0}",Nombre);
        }
        public virtual void Afinar(){
            Console.WriteLine("{0},Afinando su instrumento {0}",Nombre);
        }
        class Bajista:Musico{
            private string Bajo;
            public Bajista(string no,string B):base(no)
            {
                this.Bajo=B;
            }
            public override void Afinar(){
                Console.WriteLine("{0} Afinando su {1}",Nombre,Bajo);
            }
            /*public void Afinar1(){
                Console.WriteLine("{0} Esta afinando su bajo {1}",Nombre,B);
            }
            public void Tocar(){
                Console.WriteLine("{0} Esta utilizando su bajo {1}",Nombre,B);
            }
             */
        }
        class Guitarrista:Musico{
            private string Guitarra;
            public Guitarrista(string no, string G):base(no)
            {
                this.Guitarra=G;
            }
         public override void Afinar(){
                Console.WriteLine("{0} Afinando su {1}",Nombre,Guitarra);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Tomas=new Musico("Tomas");
            Bajista flea=new Bajista("Flea","MusicMan");
            //Guitarrista JSenoue=new Guitarrista("JSenoue","Call me crazy");
            List <Musico> grupo = new List <Musico>();
            grupo.Add(Tomas);
            grupo.Add(flea);
            foreach(Musico m in grupo){
                m.Saludar();
                m.Afinar();
            }
          
           
            
           
            
        }
    }
}
}
