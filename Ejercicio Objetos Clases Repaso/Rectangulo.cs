using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Objetos_Clases_Repaso
{
    class Rectangulo
    {
        private int largo, ancho;
        public Rectangulo()
        {

        }
        public Rectangulo(int largo,int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }
        public void SetLargo(int largo)
        {
            this.largo = largo;
        }
        public int GetLargo()
        {
            return largo;
        }
        public void SetAncho(int ancho)
        {
            this.ancho = ancho;
        }
        public int GetAncho()
        {
            return ancho;
        }
        public int Area()
        {
            return largo * ancho;
        }
        public double Diagonal()
        {
            return (Math.Sqrt(Math.Pow(Convert.ToDouble(largo), 2)+Math.Pow(Convert.ToDouble(ancho), 2)));
        }
    }
}
