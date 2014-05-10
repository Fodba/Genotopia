using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatalogueGene
{
    /// <summary>
    /// type enumérable qui permet de distinguer chaque base azotée.
    /// </summary>
    public enum BaseADN { BaseA, BaseC, BaseG, BaseT, BaseU }
    public class BaseAzotee
    {
        private Random r = new Random();
        public BaseADN Type;
        public string Nom;

        public BaseAzotee(bool adn = true)
        {
            int n;
            if (adn)
            {
                n = r.Next(4);
            }
            else
            {
                n = r.Next(5);
            }
            switch (n)
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
        }
    }
}
