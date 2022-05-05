using System.Collections.Generic;
namespace EjerciciosDia4
{
    

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
