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

        public void VerExpediente(int idx,out int nro, out int dni, out double monto)
        {
            nro = 0;
            dni = 0;
            monto = 0;
            if (idx >= 0 && idx < Contador)
            { 
                nro=expedientes[idx];
                dni=DNIs[idx];
                monto=montos[idx];
            }
        }

        public void OrdenarExpedientes()
        {
            for (int n = 0; n < Contador - 1; n++)
            {
                for (int m = n+1; m < Contador ; m++)
                { 
                    if (expedientes[n] > expedientes[m])
                    {
                     
                        int tempExp = expedientes[n];
                        expedientes[n] = expedientes[m];
                        expedientes[m] = tempExp;
                     
                        int tempDNI = DNIs[n];
                        DNIs[n] = DNIs[m];
                        DNIs[m] = tempDNI;
                     
                        double tempMonto = montos[n];
                        montos[n] = montos[m];
                        montos[m] = tempMonto;
                    }
                }
            }
        }

        public double CalcularMontoPromedio()
        {
            double suma = 0;
            for (int n = 0; n < Contador; n++)
            {
                suma += montos[n];
            }
            if(Contador>0)
                return suma / Contador;
            return 0;
        }

        public int[] MayoresAlPromedio(out int cantidad)
        {
            double promedio = CalcularMontoPromedio();
            int[] idxsMayores = new int[Contador];

            cantidad = 0;
            for (int n = 0; n < Contador; n++)
            {
                if (montos[n] > promedio)
                {
                    idxsMayores[cantidad] = n;
                    cantidad++;
                }
            }
            return idxsMayores;
        }

        public int VerContador()
        {
            return Contador;
        }
    }
}
