using System;
namespace EjerciciosDia4
{
    #region classes


    class Persona
    {
        private string nombre;
        private int edad;
        private int dNI;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int DNI { get => dNI; set => dNI = value; }

        public Persona()
        {

        }

        public Persona(string nombre, int edad, int dNI)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            DNI = dNI;
        }

        override public string ToString()
        {
            return "El nombre de esta persona es " + this.Nombre;
        }
        
        public void mostrar ()
        {
            Console.WriteLine("El nombre de esta persona es " +this.nombre);
            Console.WriteLine();
            Console.WriteLine("La edad de esta persona es " +this.edad);
            Console.WriteLine();
            Console.WriteLine("El DNI de esta persona es " + this.dNI);
        }

        public bool esMayorDeEdad()
        {
            return this.edad >= 18;
        }
    }

    #endregion

}
