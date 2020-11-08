using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Interface
{
   public interface IAlgoritmoService
    {
        ObjDividendos AllValues(ObjDividendos v, int valor);
    }
}
