using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa;
            int x, y;
            int cal;
            Console.WriteLine("Digite el numero de la figura que desea obtener el area");
            Console.WriteLine("1 - circulo, 2 - rectangulo");
            cal = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de y");
            y = int.Parse(Console.ReadLine());

            Shape objshape = new Shape(x, y);
            xa = objshape.area();
            if (cal == 2)
            {
                Console.WriteLine("El area del rectangulo" + xa);
                Console.ReadLine();
            }
            Console.WriteLine("El area del circulo" + xa);
            Console.ReadLine();
        }
    }
}
