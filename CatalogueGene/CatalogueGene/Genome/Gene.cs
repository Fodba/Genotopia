using System.Collections.Generic;

namespace CatalogueGene
{
    namespace Genome
    {
        public class Gene
        {
            public string Nom;
            public string NomAbrege;
            public Activeur GenonActiveur;
            public List<Genon> Sequence;

            public Gene(int n = 3)
            {
                this.GenonActiveur = new Activeur();
                //this.Nom = this.GenonActiveur.Nom /*+ "\n"*/;
                this.Sequence = new List<Genon>();
                for (int i = 0; i < n; i++)
                {
                    Genon gn = new Codon();
                    this.Sequence.Add(gn);
                    this.Nom += gn.Nom /*+ "  "*/;
                }

            }
        }
    }
}
