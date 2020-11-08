using Domain.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class AlgoritmoService : IAlgoritmoService
    {
        public readonly IDivisores _IDivisores;
        public readonly IFatoresPrimos _IFatoresPrimos;

        public AlgoritmoService(IDivisores IDivisores, IFatoresPrimos IFatoresPrimos)
        {
            _IDivisores = IDivisores;
            _IFatoresPrimos = IFatoresPrimos;

        }

        public ObjDividendos AllValues(ObjDividendos objDividendos, int valor)
        {
           
            objDividendos.lstDivisores = _IDivisores.GetDivisores(valor);
            objDividendos.lstDivisores.Add(valor);
            objDividendos.lstNumerosPrimos = _IFatoresPrimos.PrimeNumbers(objDividendos.lstDivisores);

            return objDividendos;
        }


    }
}
