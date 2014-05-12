using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueGene
{
    public class PaireDeBase
    {
        public BaseAzotee[] Bases = new BaseAzotee[2];
        public string Nom;
        //public int Position;

        public PaireDeBase()
        {
            this.Bases[0] = new BaseAzotee();
            this.Nom += Bases[0].Nom;
            this.Bases[1] = new BaseAzotee();
            switch (Bases[0].NumeroBase)
            {
                case 0:
                    Bases[1].Type = BaseADN.BaseT;
                    Bases[1].Nom = "T";
                    break;
                case 1:
                    Bases[1].Type = BaseADN.BaseG;
                    Bases[1].Nom = "G";
                    break;
                case 2:
                    Bases[1].Type = BaseADN.BaseC;
                    Bases[1].Nom = "C";
                    break;
                case 3:
                    Bases[1].Type = BaseADN.BaseA;
                    Bases[1].Nom = "A";
                    break;
                default:
                    Bases[1].Type = BaseADN.BaseU;
                    Bases[1].Nom = "U";
                    break;
            }
            this.Nom = Bases[0].Nom + Bases[1].Nom;
        }
    }
}
