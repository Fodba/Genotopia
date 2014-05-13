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

        public PaireDeBase(BaseAzotee base1)
        {;
            this.Bases[0] = base1;
            BaseADN type;
            switch (base1.Type)
            {
                case BaseADN.BaseA:
                    type = BaseADN.BaseT;
                    break;
                case BaseADN.BaseC:
                    type = BaseADN.BaseG;
                    break;
                case BaseADN.BaseG:
                    type = BaseADN.BaseC;
                    break;
                case BaseADN.BaseT:
                    type = BaseADN.BaseA;
                    break;
                default:
                    type = BaseADN.BaseU;
                    break;
            }
            this.Bases[1] = new BaseAzotee(type);
            this.Nom = Bases[0].Nom + Bases[1].Nom;
        }
    }
}
