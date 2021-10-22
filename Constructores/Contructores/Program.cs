using System;

namespace Contructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto audi = new Auto();
            Auto ferre = new Auto(1500.5,45.5);
            Console.WriteLine(audi.getInformacion());
            Console.WriteLine(ferre.getInformacion());

            Auto a = new Auto(1500.5,88.55);
            a.setExtras(true, "cuero");
            Console.WriteLine(a.getInformacion()+" "+a.getExtras());

        }
    }

    class Auto
    {

        public Auto()
        {
            ruedas = 4;
            largo = 2300;
            ancho = 0.800;
        }

        public Auto(double largoAuto, double anchoAuto)
        {
            ruedas= 4;
            largo = largoAuto;
            ancho = anchoAuto;
        }


        public string getInformacion()
        {
            return "el auto cuenta con " + ruedas+" ruedas y un largo y ancho de "+largo+ancho;
        }


        public void setExtras(bool parametroClimatizador, string parametroTapiceria)
        {
            climatizador = parametroClimatizador;
            tapiceria = parametroTapiceria;
        }

        public string getExtras()
        {
            return "\nExtras del auto \nTapiceria " + tapiceria + "\nClimatizador " + climatizador;
        }


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

    }




}
