using System;
using System.Collections.Generic;
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
                Console.WriteLine("(2) ");
                Console.WriteLine("(3) ");
                Console.WriteLine("(4) ");
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

            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write("Por favor ingrese un nombre ");
                personas[i].Nombre = new string(Console.ReadLine());
            }

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }

            Console.WriteLine();
    }

    public void Ejercicio2()
        {

        }

    #endregion

    #region Metodos De Main


    #endregion
    }

    


    #region classes

    class Persona
    {
        private string nombre;
        private int edad;
        private int dNI;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int DNI { get => dNI; set => dNI = value; }

        public Persona(string nombre, int edad, int dNI)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            DNI = dNI;
        }

        override public string ToString()
        {
            return "the name of this person is " + this.Nombre;
        }

        public void mostrar ()
        {
            Console.WriteLine("El nombre de esta persona es " +this.nombre);
            Console.WriteLine("La edad de esta persona es " +this.edad);
            Console.WriteLine("El DNI de esta persona es " + this.dNI);

        }

        public bool esMayorDeEdad()
        {
            return this.edad >= 18;
        }
    }
    #endregion

    class Cuenta
    {
        Persona titular;
        float cantidad = 0f;

        public Cuenta()
        {

        }
        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }

        public Cuenta(Persona titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public float Cantidad { get => cantidad; set => cantidad = value; }
        internal Persona Titular { get => titular; set => titular = value; }

        public void mostrar()
        {
            titular.mostrar();
            Console.WriteLine("El dinero en esta cuenta es " + cantidad);
        }

        public void ingresar(float cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void retirar(float cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad -= cantidad;
            }
        }


    }

    class CuentaJoven : Cuenta
    {
        float bonificacion = 0f;

        public CuentaJoven(Persona titular, float cantidad, float bonificacion)
        {
            this.Titular = titular;
            this.Cantidad = cantidad;
            this.bonificacion = bonificacion;
        }

        public bool esTitularValido()
        {
            if(this.Titular.Edad >= 18 && this.Titular.Edad < 25)
            {
                return true;
            } else
            {
                return false;
            }
   
        }

        new public void retirar(float cantidad)
        {
            if(esTitularValido())
            {
                if(cantidad > 0)
                {
                    {
                        this.Cantidad -= cantidad;
                    } 
                }
            }
        }

        new public void mostrar()
        {
            Console.WriteLine("Cuenta Joven: ");
            mostrar();
            Console.WriteLine("El bono de esta cuenta es " +bonificacion+"%");
        }
    }

    class Eiffel
    {
        List<string> elementos = new List<string>();

        public void Insercion(string elemento)
        {
            elementos.Add(elemento);
        }

        public string Elemento(int pos)
        {
            if (elementos[pos] != null)
            {
                return elementos[pos];
            }
            else
            {
                return null;
            }
        }

        public void Poda()
        {
            if (elementos.Count > 0)
            {
                elementos.RemoveAt(0);
            }
        }
    }


}
