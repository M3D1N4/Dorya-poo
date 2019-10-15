using System;
using System.collections,generic;

namespace Musico
{
    class Musico
    {
        protected string nombre;
        public Musico(string n){
            nombre = n;
        }
        public void afina(){
            console.WriteLine("los afinado a su instrumento",nombre);
        }
        public void Saludo(){
            console.WriteLine("Hola soy {0}",nombre);
        }
    }
    class Bajista:Musica{
        private string bajo;
        public Bajista(string no, string b):base(no)
        {bajo=b;}
        public override void Afina(){
            console.WriteLine("{o}afinando su{1}"nombre,bajo);
        }
    }
    class Program
    {
        static void main(){
            Musico Tom=new Musico("Tom");
            Bajista flea =new Bajista("Flea","mdassa");
            tom.Saludo(); flea.Saluda();
            tom.afina(); flea.afina();

            List<Musico> grupo = new List<Musico>();
            grupo.add(tom);
            grupo.add(flea);
            foreach(musico m in grupo){
                m.Saluda();
                m.afina();
            }
        }
    }}
       
