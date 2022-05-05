using System;
namespace EjerciciosDia4
{
    #region classes

    class Cuenta
    {
        Persona titular;
        float cantidad = 0f;
            public float Cantidad { get => cantidad; set => cantidad = value; }
            internal Persona Titular { get => titular; set => titular = value; }

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

      

        public virtual void mostrar()
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

        public virtual void retirar(float cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad -= cantidad;
            }
        }


    }

    #endregion

}
