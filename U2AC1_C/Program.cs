using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC1_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //presentacion
            Console.WriteLine("Calificaciones Finales");
            Console.WriteLine("Todos Los Profesores Evaluaron 4 Unidades \n");

            //Variables de datos y datos ingresados
            string nombre, matricula;
            Console.WriteLine("Ingrese Nombre Completo Del Alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Matricula Del Alunmo");
            matricula = Console.ReadLine();


            //variables de unidades y datos ingresados
            decimal Unidad1;
            decimal Unidad2;
            decimal Unidad3;
            decimal Unidad4;
            decimal Sumatoria;
            decimal Final;

            Console.WriteLine("Ingresa Calificacion De Unidad 1"); 
            Unidad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa Calificacion De Unidad 2");
            Unidad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa Calificacion De Unidad 3");
            Unidad3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa Calificacion De Unidad 4");
            Unidad4 = Convert.ToInt32(Console.ReadLine());

            //Suma de cañificaciones
            Sumatoria = Unidad1 + Unidad2 + Unidad3 + Unidad4 ;

            if (Final > 70)
            {
                Console.WriteLine("Felicidades aprobaste tu materia con {0}" Final);
            }
            else
            {
                Console.WriteLine("Reprobo, recurse su materia");
            }

            Console.ReadKey();
        }
    }
}
