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
            Console.WriteLine("{0},Afine su instrumento {0}",Nombre);
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
            public Guitarrista(string no, string Guitarra):base(no)
            {
                this.Guitarra=Guitarra;
            }
            public void Afinar2(){
                Console.WriteLine("{0} Esta afinando su Guitarra {1}",Nombre,Guitarra);
            }
            public void Tocar1(){
                Console.WriteLine("{0} Esta utilizando su guitarra {1}",Nombre,Guitarra);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Tomas=new Musico("Tomas");
            Bajista flea=new Bajista("Flea","MusicMan");
            //Guitarrista JSenoue=new Guitarrista("JSenoue","Call me crazy");
            Console.WriteLine(Tomas.Saludar());
            Tomas.Afinar();flea.Afinar();

            List <Musico> grupo = new List <Musico>();
            grupo.Add(Tomas);
            grupo.Add(flea);
            foreach(Musico m in grupo){
                Console.WriteLine(m.Saludar());
                m.Afinar();
            }
          
           
            
           
            
        }
    }
}
