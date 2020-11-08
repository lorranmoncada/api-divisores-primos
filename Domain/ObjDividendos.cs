using System.Collections;

namespace Domain.Interface
{
    public class ObjDividendos
    {

        public ObjDividendos() {
            lstDivisores = new ArrayList();

            lstNumerosPrimos = new ArrayList();
        }

        public ArrayList lstDivisores { get; set; }
        public ArrayList lstNumerosPrimos { get; set; }
    }
}