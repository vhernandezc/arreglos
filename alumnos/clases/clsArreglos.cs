using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos.clases
{
    class clsArreglos
    {
        
        private int[] arreglotemporal;
        private int[] datos;
        private int i, j, datotemporal;
        private int tamanoarreglo = 0;
        private int b;

        public int gettamanoarreglo()
        {
            return datos.Length;
        }
        public clsArreglos(int[] arregloParametro)
        {
            datos = arregloParametro;
            tamanoarreglo = datos.Length;
        }

        public clsArreglos(int b)
        {
            this.b = b;
        }

        public int[] metodoburbuja()
        {
            arreglotemporal = datos;

            for (i = 0; i < tamanoarreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoarreglo; j++)

                {
                    if (arreglotemporal[i] > arreglotemporal[j])
                    {
                        datotemporal = arreglotemporal[i];
                        arreglotemporal[i] = arreglotemporal[j];
                        arreglotemporal[j] = datotemporal;
                    }
                }

            }
            return arreglotemporal;

        }

       
    }

}   
