using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Objetos_Clases_Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect1 = new Rectangulo(3,5);
            Console.WriteLine("El largo es "+rect1.GetLargo());
            Console.WriteLine("El ancho es "+rect1.GetAncho());
            Console.WriteLine("El área es "+rect1.Area());
            Console.WriteLine("La diagonal es "+rect1.Diagonal());
            Console.ReadKey();
        }
    }
}
