using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueGene
{
    public class RandomGenerator
    {
        static Random r = new Random();
        public static BaseADN TypeBaseAleatoire(int n = 4)
        {
            BaseADN Base;
            switch (r.Next(n))
            {
                case 0:
                    Base = BaseADN.BaseA;
                    break;
                case 1:
                    Base = BaseADN.BaseC;
                    break;
                case 2:
                    Base = BaseADN.BaseG;
                    break;
                case 3:
                    Base = BaseADN.BaseT;
                    break;
                default:
                    Base = BaseADN.BaseU;
                    break;
            }
            return Base;
        }
        public static BaseAzotee BaseAleatoire(int n = 4)
        {
            BaseAzotee Base = new BaseAzotee(RandomGenerator.TypeBaseAleatoire(n));
            return Base;
        }
    }
}
