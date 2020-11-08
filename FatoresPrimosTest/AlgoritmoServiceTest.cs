using Domain.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace FatoresPrimosTest
{
    public class AlgoritmoServiceTest : IAlgoritmoService
    {

        private readonly ObjDividendos _ObjDividendos;
        public AlgoritmoServiceTest()
        {
            _ObjDividendos = new ObjDividendos();
            List<int> lstD = new List<int> { 1, 2, 3, 5, 6, 9, 10, 15, 18, 30, 45, 90 };
            List<int> lstNP = new List<int> { 2, 3, 5 };

            _ObjDividendos.lstDivisores.AddRange(lstD);
            _ObjDividendos.lstNumerosPrimos.AddRange(lstNP);
        }

        public ObjDividendos AllValues(ObjDividendos v, int valor)
        {
            return _ObjDividendos;
        }
    }
}
