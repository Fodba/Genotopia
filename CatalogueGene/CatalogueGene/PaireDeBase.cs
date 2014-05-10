using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CatalogueGene
{
    public class PaireDeBase
    {
        private Random r = new Random();
        /// <summary>
        /// Variable servant à identifier une paire de base donnée.
        /// </summary>
        public BaseAzotee[] BasE = new BaseAzotee[2];
        public string Nom;
        /// <summary>
        /// identifie la position de la paire de base au sein du brin d'adn
        /// </summary>
        public int Position;

        public PaireDeBase(int a = 0)
        {
            this.Position = a;
            for (int i = 0; i < this.BasE.Length; i++)
            {
                this.BasE[i] = new BaseAzotee();
                this.Nom += this.BasE[i].Nom;

            }
        }
    }
}
