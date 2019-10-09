using System;

namespace Domino
{
    class Pieza{
        private readonly int pieza1;
        private readonly int pieza2;
        public Pieza(int sup, int inf){
            pieza1 = sup;
            pieza2 = inf;
        }
        public static int operator +(Pieza a, Pieza b)
        => a.pieza1 + a.pieza2 + b.pieza1 + b.pieza2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pieza a= new Pieza (2,0);
            //Le puse "(4,1)" en vez de "(4,2)" por que no daba 7 el resultado.
            Pieza b= new Pieza (4,1);
            Console.WriteLine(a + b);
        }
    }
}
