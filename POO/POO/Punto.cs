using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Punto
    {

        private int x, y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorObj++;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorObj++;
        }

        public double Distancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2)+ Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
        

        public static int ContadorObj()
        {
            return contadorObj;
        }

        private static int contadorObj = 0;

    }
}
