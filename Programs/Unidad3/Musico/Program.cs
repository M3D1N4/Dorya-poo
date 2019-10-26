using System;

namespace Musico
{
    class Musico{
        protected string Nombre;
        public Musico(string N)
        {
            Nombre = N;
        }

        public void Saludar(){
            Console.WriteLine("Hola, soy {0}",Nombre);
        }
        public void Afinar(){
            Console.WriteLine("{0},Afine su instrumento {0}",Nombre);
        }
        class Bajista:Musico{
            private string Bajo;
            public Bajista(string no,string Bajo):base(no)
            {
                this.Bajo=Bajo;
            }
            public void Afinar1(){
                Console.WriteLine("{0} Esta afinando su bajo {1}",Nombre,Bajo);
            }
            public void Tocar(){
                Console.WriteLine("{0} Esta utilizando su bajo {1}",Nombre,Bajo);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Tomas=new Musico("Tomas");
            Tomas.Saludar();
        }
    }
}
