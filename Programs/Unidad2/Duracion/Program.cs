using System;

namespace Duracion
{
    class Tiempo{
private int Horas;
private int Minutos;
private int Segundos;
private int MinutosT;

public Tiempo(int H, int M, int S, int MT){
Horas = H;
Minutos = M;
Segundos = S;
MinutosT = MT;
}
public void print(){
   
    Console.WriteLine("Horas :"+Horas+" Minutos : "+Minutos+" Segundos :"+Segundos );
     Console.WriteLine("Minutos totales :" +((Horas*60)+Minutos) );
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tiempo Pelicula = new Tiempo(2,15,12,0);
            Tiempo Cancion = new Tiempo(0,02,15,0);
            Tiempo Partido = new Tiempo(2,00,10,0);
            Console.WriteLine("-Pelicula-");
            Pelicula.print();
            Console.WriteLine("-Canción-");
            Cancion.print();
            Console.WriteLine("-Partido-");
            Partido.print();
            
           
        }
    }
}