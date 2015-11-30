using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionLambda
{
    public class MiClase
    {
        public void Inicia()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            ParaCadaUno(arreglo, (int ix) => 
            {
                Console.WriteLine(ix * 2);
            });
            Console.Read();
        }

        private void ParaCadaUno(int[] arreglo, Funcion funcion)
        {
            foreach (int ix in arreglo)
            {
                funcion(ix);
            }
        }

        private delegate void Funcion(int ix);
    }
}
