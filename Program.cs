using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejemplo1
{
    class suma
    {
        
     
        static void Main(string[] args)
        {

            int mag1, mag2, fas1, fas2;
            
                      
            Console.WriteLine("1ST VECTOR");
            Console.WriteLine("Input Magnitude 1");
            mag1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Phase 1");
            fas1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2ND VECTOR");
            Console.WriteLine("Input Magnitude 2");
            mag2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Phase 2");
            fas2 = int.Parse(Console.ReadLine());

            int[] array1 = { mag1,fas1};
            int[] array2 = { mag2, fas2 };

          
            Console.WriteLine("1st Polar Vector: ");
            Console.WriteLine("[{0}]", string.Join(", ", array1));

            Console.WriteLine("2nd Polar Vector: ");
            Console.WriteLine("[{0}]", string.Join(", ", array1));

            Console.WriteLine("Enter to Continue...........");
            Console.ReadLine();

          

            Complex V1 = Complex.FromPolarCoordinates(mag1,fas1 * Math.PI / 180);
            Console.WriteLine("1st Rectangular Vector = {0}:", V1);

            Complex V2 = Complex.FromPolarCoordinates(mag2, fas2 * Math.PI / 180);
            Console.WriteLine("2nd Rectangular Vector = {0}:", V2);

            Complex V3 = V1 + V2;
            Console.WriteLine("Final Rectangular Vector = {0}:", V3);
            Console.WriteLine("Enter to Continue...........");
            Console.ReadLine();

            double a, b, c;
            a = Math.Sqrt((V3.Real * V3.Real) + (V3.Imaginary * V3.Imaginary));
            b = Math.Atan(V3.Imaginary / V3.Real);
            c = (b * (180 / Math.PI));

            double[] array3 = { a, c };
            Console.WriteLine("[{0}]", string.Join(", ", array3));

            Console.WriteLine("Final Polar Vector = {0} < {1}", a, c);
            Console.WriteLine("Enter to Exit...........");
            Console.ReadLine();




        }
    }
}
