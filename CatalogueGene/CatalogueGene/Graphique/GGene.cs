using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using CatalogueGene.Fonctions;
using CatalogueGene.Console;
using CatalogueGene.Genome;
using CatalogueGene.Existence;

namespace CatalogueGene
{
    namespace Graphique
    {
        public class GGene : Panel
        {
            public string Nom;
            public Color couleur;
            private Gene geneRecu;
            private List<Panel> GBase;

            public GGene(Gene gene)
            {
                geneRecu = gene;
                this.Nom = geneRecu.Nom;
            }

            public void AfficheGene(Form fenetre, int typeAffichage = 0)
            {
                GGene soi = this;
                switch (typeAffichage)
                {
                    case 1:
                        Couleur.ColoreGeneSplit(geneRecu, soi);
                        break;
                    case 2:
                        Couleur.ColoreGene(geneRecu, soi);
                        break;
                    default:
                        Couleur.DoubleAffichage(geneRecu, soi);
                        break;
                }
                fenetre.Controls.Add(soi);
                fenetre.Size = soi.Size;
            }
        }

        public class Gbase : Label
        {
            public Gbase()
            {
                this.Size = new System.Drawing.Size(15, 15);
            }
        }

        public class GCodon : Label
        {
            public GCodon()
            {
                this.Size = new System.Drawing.Size(60, 60);
            }
        }
    }
}
