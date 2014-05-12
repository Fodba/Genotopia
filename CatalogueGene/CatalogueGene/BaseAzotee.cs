using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CatalogueGene
{
    /// <summary>
    /// énumération qui identifie les types de Base existants.
    /// </summary>
    public enum BaseADN { BaseA, BaseC, BaseG, BaseT, BaseU }
    public class BaseAzotee
    {
        public Random r = new Random();
        public BaseADN Type;
        public string Nom;
        /// <summary>
        /// nombre servant à identifier le type de Base.
        /// </summary>
        public int NumeroBase;

        public BaseAzotee(int n = 4)
        {
            this.NumeroBase = r.Next(n);
            switch (this.NumeroBase)
            {
                case 0:
                    this.Type = BaseADN.BaseA;
                    this.Nom = "A";
                    break;
                case 1:
                    this.Type = BaseADN.BaseC;
                    this.Nom = "C";
                    break;
                case 2:
                    this.Type = BaseADN.BaseG;
                    this.Nom = "G";
                    break;
                case 3:
                    this.Type = BaseADN.BaseT;
                    this.Nom = "T";
                    break;
                default:
                    this.Type = BaseADN.BaseU;
                    this.Nom = "U";
                    break;
            }
            /// arret du processus pour permettre la génération d'un autre nombre aléatoire.
            Thread.Sleep(20);
        }
    }
}
