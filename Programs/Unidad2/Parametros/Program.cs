using System;

namespace Parametros
{
    class Programa
    {
        public string nombre;
        public string apellido;

        public Programa(){
             nombre = "Pepito";
             apellido = "jaimito";
        }
       
    }

    class Anonimo{
          static public void anonimiza(Programa p){
                        p.nombre = "xxx";
                        p.apellido = "xxx";
          }
          static void main(){
               Programa espia = new Programa();

               Console.WriteLine(espia.nombre);
               anonimiza(espia);
               Console.WriteLine(espia.nombre);
          }
    }

    
}
