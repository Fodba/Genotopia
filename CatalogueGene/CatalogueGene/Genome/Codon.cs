using CatalogueGene.Fonctions;

namespace CatalogueGene
{
    namespace Genome
    {
        public class Codon : Genon
        {
            /// <summary>
            /// ensemble de trois paires de Base.
            /// </summary>
            public Codon()
            {
                this.Paire = new PaireDeBase[3];
                for (int i = 0; i < this.Paire.Length; i++)
                {
                    this.Paire[i] = new PaireDeBase(RandomGenerator.BaseAleatoire());
                    this.Nom += this.Paire[i].Nom;
                }
            }
        }
    }
}
