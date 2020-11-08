using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class FatoresPrimos : IFatoresPrimos
    {
        public ArrayList PrimeNumbers(ArrayList numeros)
        {
            ArrayList numbers = new ArrayList();
            for (var i = 0; i <= numeros.Count - 1; i++)
            {
                if (IsNumeroPrimo(numeros[i]))
                {
                    numbers.Add(numeros[i]);
                }
            }

            return numbers;
        }

        public bool IsNumeroPrimo(object val)
        {
            int number = Convert.ToInt32(val);

            for (var i = 2; i < number; i++)
            {
                var result = number % i;
                if (result == 0)
                    return false;
            }

            return number > 1 ? true : false;
            
        }
    }
}
