using CatalogueGene.Fonctions;

namespace CatalogueGene
{
    namespace Genome
    {
        public class Activeur : Genon
        {
            public Activeur()
            {
                this.Paire = new PaireDeBase[2];
                for (int i = 0; i < this.Paire.Length; i++)
                {
                    this.Paire[i] = new PaireDeBase(RandomGenerator.BaseAleatoire());
                    this.Nom += this.Paire[i].Nom;
                }
            }
        }
    }
}
