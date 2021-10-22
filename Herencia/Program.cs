using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano bob = new Humano("BOB");
            Caballo elis = new Caballo("caballiro");
            Gorila haku = new Gorila("haku");

            Mamiferos[] arrayMamiferos = new Mamiferos[3];
            arrayMamiferos[0] = bob;
            arrayMamiferos[1] = elis;
            arrayMamiferos[2] = haku;

            for(int i = 0; i < 3; i++)
            {
                arrayMamiferos[i].pensar();
            }

            IMamiferosTerrestres Icaballito = elis;
            Icaballito.numeroPatas();

         

        }
    }


    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }
    

    interface IAnimalesDeportes
    {
        string tipoDeporte();
        Boolean esOlimpico();
    }


    interface ISaltaConPatas
    {
        int numeroPatas();
    }



    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("soy capaz de respirar");
        }

        public abstract void getNombre();
        
    }


    class Mamiferos
    {

        private string nombreSerVivo;

        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("respira");
        }


        public void criar()
        {
            Console.WriteLine("Cuidar las crias hasta que puedan solos ");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es "+nombreSerVivo);
        }


        public virtual void pensar()
        {
            Console.WriteLine("Piensa");
        }


        
    }


    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltaConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void rebusnar()
        {
            Console.WriteLine("rebusna");
        }

       int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        public string tipoDeporte()
        {
            return "equitacion";
        }

        public Boolean esOlimpico()
        {
            return true;
        }

       int ISaltaConPatas.numeroPatas()
        {
            return 2;
        }
    }


    class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("es capaz de pensar");
        }
    }


    class Gorila : Mamiferos
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void treparArboles()
        {
            Console.WriteLine("es capaz de trepar arboles");
        }

        new public void pensar()
        {
            Console.WriteLine("capaz de pensamiento instintivo");
        }
    }



    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("estoy nadando ");
        }

    }

}
