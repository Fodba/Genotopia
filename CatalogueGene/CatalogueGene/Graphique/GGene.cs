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

namespace CatalogueGene
{
    namespace Graphique
    {
        public class GGene : Panel
        {
            public string Nom;
            public Color couleur;
            private List<Panel> GBase;

            public GGene(Gene gene)
            {

                this.Nom = gene.Nom;
                ColoreGene(gene);
                this.Location = new System.Drawing.Point(0, 0);
            }
            private void ColoreGene(Gene gene)
            {
                int longueur = 0;
                for (int i = 0; i < gene.GenonActiveur.Paire.Length; i++)
                {
                    PaireDeBase paire=gene.GenonActiveur.Paire[i];
                    for (int j = 0; j < paire.Bases.Length ; j++)
			        {
                        BaseAzotee bAse = paire.Bases[j];
                        Gbase p = new Gbase();
                        p.Name = bAse.Nom + j;
                        p.Text = bAse.Nom;
                        p.BackColor = ColoreBase(bAse);
                        p.Location = new Point(i * 15, j * 15);
                        this.Controls.Add(p);
                    }
                    longueur += 15;
                }
                int decalage = 45;
                longueur += 15;
                foreach (var genon in gene.Sequence)
                {
                    for (int i = 0; i < genon.Paire.Length; i++)
                    {
                        PaireDeBase paire = genon.Paire[i];
                        for (int j = 0; j < paire.Bases.Length; j++)
                        {
                            BaseAzotee bAse = paire.Bases[j];
                            Gbase p = new Gbase();
                            p.Name = bAse.Nom + j;
                            p.Text = bAse.Nom;
                            p.BackColor = ColoreBase(bAse);
                            p.Location = new Point((i * 15) + decalage, j * 15);
                            this.Controls.Add(p);
                        }
                        longueur += 15;
                    }
                    decalage += (genon.Paire.Length * 15)/* + 15*/;
                    longueur += 15;
                }
                this.Size = new System.Drawing.Size(longueur, 60);
            }
            private Color ColoreBase(BaseAzotee bAse)
            {
                switch (bAse.Nom)
                {
                    case "A":
                        couleur = System.Drawing.Color.Green;
                        break;
                    case "C":
                        couleur = System.Drawing.Color.Red;
                        break;
                    case "G":
                        couleur = System.Drawing.Color.Yellow;
                        break;
                    case "T":
                        couleur = System.Drawing.Color.Magenta;
                        break;
                    default:
                        couleur = System.Drawing.Color.Gray;
                        break;
                }
                return couleur;
            }

            public void AfficheGene(Form fenetre)
            {
                GGene soi = this;
                fenetre.Controls.Add(soi);
            }
        }

        public class Gbase : Label
        {
            public Gbase()
            {
                this.Size = new System.Drawing.Size(15, 15);
            }
        }
    }
}
