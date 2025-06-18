using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Models
{
    internal class Servicio
    {
        int[]expedientes = new int[100];
        int[] DNIs = new int[100];
        double[] montos = new double[100];
        int Contador;

        public void RegistrarExpediente(int expediente, int dni, double monto)
        {
            if (Contador < 100)
            {
                expedientes[Contador] = expediente;
                DNIs[Contador] = dni;
                montos[Contador] = monto;
                Contador++;
            }
        }

        public int VerContador()
        {
            return Contador;
        }
    }
}
