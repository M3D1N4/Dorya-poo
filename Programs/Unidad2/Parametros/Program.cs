using System;
using System.Collections.Generic;

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
          static public void cambia(Programa p){
                        p = new Programa();
                        p.nombre = "Jhony";
                        p.apellido = "Joe";
          }
          static public void cambia_ref(Programa p){
                        p = new Programa();
                        p.nombre = "Jhony";
                        p.apellido = "Joe";
          }
          static void Main(){
               Programa espia = new Programa();

               Console.WriteLine(espia.nombre);
               anonimiza(espia);
               Console.WriteLine(espia.nombre);
               cambia(espia);
               Console.WriteLine(espia.nombre);
               cambia_ref(espia);
               Console.WriteLine(espia.nombre);
               
          }
    }


}
