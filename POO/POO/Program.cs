using System;

namespace POO
   
{
    class Program
    {
        static void Main(string[] args)
        {
            
            realizarTarea();

            var miVariable = new { Nombre = "Dylan", Edad = 20 };
            
            
        }


        static void realizarTarea()
        {
            //TODO: 
            Punto destino = new Punto(5,5);
            Punto origen= new Punto();

            double distancia = origen.Distancia(destino);
            Console.WriteLine(distancia);

            Console.WriteLine("cantidad de objetos "+Punto.ContadorObj());
        }

    }

 

}
