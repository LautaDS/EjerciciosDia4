using System;
namespace EjerciciosDia4
{
    #region classes

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

        override public void retirar(float cantidad)
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

        override public void mostrar()
        {
            Console.WriteLine("Cuenta Joven: ");
            mostrar();
            Console.WriteLine("El bono de esta cuenta es " +bonificacion+"%");
        }
    }

    #endregion

}
