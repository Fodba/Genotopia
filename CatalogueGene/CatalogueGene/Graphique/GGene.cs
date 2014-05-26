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
using CatalogueGene.Existence.Apparence;
using CatalogueGene.Existence.Vie.Habitat;

namespace CatalogueGene
{
    namespace Graphique
    {
        public class GGene : Panel
        {
            public string Nom;
            public Color couleur;
            private Gene geneRecu;
            public bool dejaColore = false;
            public int[] RGB = new int[3];

            public GGene(Gene gene)
            {
                geneRecu = gene;
                this.Nom = geneRecu.Nom;
            }

            public void AfficheGene(Form fenetre)
            {
                GGene soi = this;
                soi.Controls.Clear();
                Couleur.AfficheSequence(geneRecu, soi);

                fenetre.Controls.Add(soi);
                //fenetre.Size = soi.Size;
            }

            public void AfficheGene(Panel panel, bool typeAffichage = false)
            {
                GGene soi = this;
                switch (typeAffichage)
                {
                    case true:
                        Couleur.AfficheSequence(geneRecu, soi);
                        break;
                    default:
                        if (!this.dejaColore)
                        {
                            RGB = Couleur.ColoreGene(geneRecu, soi);
                            this.dejaColore = true;
                        }
                        soi.BackColor = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
                        break;
                }

                panel.Controls.Add(soi);
                //fenetre.Controls.Add(panel);
                //fenetre.Size = soi.Size;
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
