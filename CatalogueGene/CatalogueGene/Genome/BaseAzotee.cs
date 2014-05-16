using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CatalogueGene
{
    namespace Genome
    {
        /// <summary>
        /// énumération qui identifie les types de Base existants.
        /// </summary>
        public enum BaseADN { BaseA, BaseC, BaseG, BaseT, BaseU }
        /// <summary>
        /// classe représentant une Base azotée d'ADN.
        /// </summary>
        public class BaseAzotee
        {
            public BaseADN Type;
            public string Nom;

            public BaseAzotee(BaseADN type)
            {
                this.Type = type;
                this.Nom = type.ToString().Substring(4);
            }
        }
    }
}
