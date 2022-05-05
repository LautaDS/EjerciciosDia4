using System;
namespace EjerciciosDia4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int ej;
            do
            {
                Console.WriteLine("Por favor elija que ejercicio quiere ver:");
                Console.WriteLine("(1) Ejercicio 1");
                Console.WriteLine("(2) Ejercicio 8, albumes.");
                Console.WriteLine("(0) Salir");

                try
                {
                    ej = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No hay un ejercicio cargado con ese input, recuerde ponerlo con numeros.");
                    ej = 99999;
                }
                switch (ej)
                {
                    case (1):
                        program.Ejercicio1();
                        break;

                    case (2):
                        program.Ejercicio2();
                        break;

                    case (0):
                        break;
                    case (99999):
                        break;

                    default:
                        break;
                }

            } while (ej != 0);

            Console.WriteLine("Gracias por revisar mis ejercicios");
            Console.ReadLine();
        }
        
        
    #region Ejercicios

    public void Ejercicio1()
    {
            Persona[] personas = new Persona[3];
            string nombre;
            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write("Por favor ingrese un nombre: ");
                nombre = Console.ReadLine();
                personas[i] = new Persona();
                personas[i].Nombre = nombre;
              
            }

            Console.WriteLine();

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].ToString());
                Console.WriteLine();
            }

            Console.WriteLine();
    }

    public void Ejercicio2()
        {
            int fotos;
            do
            {

                Console.WriteLine("Por favor ingrese cuantas pagians de album el ultimo album tendra");
                try
                {
                    fotos = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ese no es un numero correcto");
                    fotos = 0;
                }
            } while (fotos == 0);

            AlbumTest albumTest = new AlbumTest(fotos);
            albumTest.Mostrar();
            Console.ReadLine();
        }

    #endregion

    
    }


}
