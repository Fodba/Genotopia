using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueGene
{
    public class Gene
    {
        public string Nom;
        public Activeur GenonActiveur;
        public List<Genon> Sequence;

        public Gene(int n = 3)
        {
            this.GenonActiveur = new Activeur();
            this.Sequence = new List<Genon>();
            for (int i = 0; i < n; i++)
            {
                Genon gn = new Codon();
                this.Sequence.Add(gn);
                this.Nom += gn.Nom + "  ";
            }

        }
    }
}
