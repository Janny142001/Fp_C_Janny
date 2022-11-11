using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_AC2_1C_Janeth_Rodriguez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = (System.ConsoleColor)12;

            string MatriculaCorrecta, Matricula, NombreCorrecto, NombrePerfil, Nombre, Edad, NumeroTelefonico, Escuela, Titulo;
            MatriculaCorrecta = "2210000149";
            NombreCorrecto = "Janny";
            short Continuar = 1;
            NombrePerfil = "Janeth Esmeralda Rodriguez Hernandez";
            Edad = "21 Años";
            NumeroTelefonico = "8721177352";
            Escuela = "Univerdsidad Tec San Pedro";
            short Seleccion;
            int Seleccion1, Seleccion2, Seleccion3;

            Console.WriteLine("Bienvenido A Tu Sistema De Consola Editable \n");
            while (Continuar == 1)
            {
                Console.WriteLine("Ingrese Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Matricula: "),
                Matricula = Console.ReadLine();

                if (string.Compare(NombreCorrecto, Nombre) == 0)
                {
                    Console.WriteLine("Nombre Correcto");
                    Continuar = 0;
                }
                else
                {
                    Console.WriteLine("Nombre Incorrecto");
                    Continuar = 1;
                }
                if (string.Compare(MatriculaCorrecta, Matricula) == 0)
                {
                    Console.WriteLine("Matricula Correcta");
                    Continuar = 0;
                }
                else
                {
                    Console.WriteLine("Matricula Incorrecta");
                    Continuar = 1;
                }
            
                    while(Continuar == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Haz Ingresado A Tu Perfil \n");
                    Console.WriteLine("Nombre. {0}", NombrePerfil);
                    Console.WriteLine("Matrucula {0}", MatriculaCorrecta);
                    Console.WriteLine("Edad: {0}", Edad);
                    Console.WriteLine("Telefono: {0}", NumeroTelefonico);
                    Console.WriteLine("Escuela: {0}", Escuela);

                    Console.WriteLine("Escriba '1' Para Cambiar El Color De Fondo \n '2' Para Cambiar el Color  De La Letra \n Escriba '3' Para Cambiar El Tamaño\n Y Escriba '4' Para Cambiar El Nombre \n '0' Para Cerrar");
                    Seleccion = Convert.ToInt16(Console.ReadLine());

                    if(Seleccion == 0)
                        {
                        Continuar = 1;
                    }
                    else if(Seleccion == 1)
                    {

                    }
                }
            }

        }
    }
}
