using System;

namespace Duracion
{
    class Tiempo{
private int Horas;
private int Minutos;
private int Segundos;

public Tiempo(int H, int M, int S){
Horas = H;
Minutos = M;
Segundos = S;
}
public void print(){
    Console.WriteLine("Horas :"+Horas+" Minutos : "+Minutos+" Segundos :"+Segundos );
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tiempo Pelicula = new Tiempo(2,15,12);
            Tiempo Cancion = new Tiempo(0,02,15);
            Tiempo Partido = new Tiempo(2,00,10);
            Pelicula.print();
            Cancion.print();
            Partido.print();
            
           
        }
    }
}
