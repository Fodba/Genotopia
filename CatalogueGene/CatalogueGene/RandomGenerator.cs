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
        /// <summary>
        /// retourne un BaseADN aléatoire
        /// </summary>
        /// <param name="nombreBase">nombre max de Bases parmis lesquelles faire la sélection</param>
        /// <returns></returns>
        public static BaseADN TypeBaseAleatoire(int nombreBase = 4)
        {
            BaseADN Base;
            switch (r.Next(nombreBase))
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
        /// <summary>
        /// retourne un BaseAzotee aléatoire
        /// </summary>
        /// <param name="nombreBase">nombre max de Bases parmis lesquelles faire la sélection</param>
        /// <returns></returns>
        public static BaseAzotee BaseAleatoire(int nombreBase = 4)
        {
            BaseAzotee Base = new BaseAzotee(RandomGenerator.TypeBaseAleatoire(nombreBase));
            return Base;
        }
    }
}
