using Domain;
using System;
using System.Collections;

namespace Entities
{
    public class Divisores : IDivisores
    {
        public ArrayList GetDivisores(int numero)
        {
            int a = numero;
            int aux = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    ++aux;
                }
            }

            ArrayList diva = new ArrayList(aux);

            for(int i = 0; i < aux; i++)
            {
                diva.Add(i);
            }

            int k = 0;
            aux = 0;

            for (int i = 1; i < a; i++)
            {
                ++aux;
                if (a % aux == 0)
                {
                    diva[k++] = aux;
                }
            }

            return diva;
        }
    }
}
