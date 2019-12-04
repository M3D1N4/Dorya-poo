using System;
using System.Collections.Generic;

namespace Cola
{
    class Program{
        static void Main(string[] args){            
            //  Código Queue que contiene los elementos en la lista "row"  //
            Queue <string> row = new Queue <string>();
                row.Enqueue("Yeah");
                 row.Enqueue("Cool");
                  row.Enqueue("AWESOME!");
                   row.Enqueue("OUTSTANDING!");
                    row.Enqueue("AMAZING!");
                     row.Enqueue("Failure");
                      row.Enqueue("Try again");

            Console.WriteLine("-. Hay {0} elementos en este momento, son los siguientes: .-", row.Count);
            //   Muestra los elementos en la cola 1 por 1 en orden(FIFO)   //
            foreach(string fila in row){
                Console.WriteLine(fila);
            }
            Console.ReadLine();
        }
    }
}
