using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public interface IFatoresPrimos
    {
        ArrayList PrimeNumbers(ArrayList numeros);
        bool IsNumeroPrimo(object numero);
    }
}
