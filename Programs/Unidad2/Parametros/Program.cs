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
                  
          public static void anonimiza(Programa p){
              p.nombre = "xxxx";
          }
          public static void anonimiza1(Programa p1){
              p1.apellido = "xxxxx";
          }
          public static void cambia(ref Programa p){
              p = new Programa();
              p.nombre = "new";
              p = new Programa();
              p.apellido = "new";
          }

         /*  static public void anonimiza(Programa p){
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
             
          }*/ 
          class Program{
              static void duplica( ref int x){
                  x = x * 2;
              }
              static int suma(int x, int y){
                  return x+y;
              }
              static void suma(int x, int y, out int resultado){
                  resultado = x + y;
              }
              static void Main(string[]args){
                  int a = 2;
                  int b = 3;
                  int r = suma(a,b);
                  int r2;
                  suma(a,b,out r2);

                  Console.WriteLine(r);
                  Console.WriteLine(r2);

                  Programa p = new Programa();
                  Console.WriteLine(p.nombre);
                  Anonimo.anonimiza(p);
                  Anonimo.cambia(ref p);
                  Programa p1 = new Programa();
                  Console.WriteLine(p.apellido);
                  Anonimo.anonimiza(p);
                  Anonimo.cambia(ref p);
              }
          }
    }


}
