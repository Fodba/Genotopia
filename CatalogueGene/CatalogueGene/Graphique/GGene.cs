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
            private Gene geneRecu;
            private List<Panel> GBase;

            public GGene(Gene gene)
            {
                geneRecu = gene;
                this.Nom = geneRecu.Nom;
            }
            private void ColoreGeneSplit(Gene gene,GGene soi)
            {
                int longueur = 0;
                for (int i = 0; i < gene.GenonActiveur.Paire.Length; i++)
                {
                    PaireDeBase paire = gene.GenonActiveur.Paire[i];
                    for (int j = 0; j < paire.Bases.Length; j++)
                    {
                        BaseAzotee bAse = paire.Bases[j];
                        Gbase p = new Gbase();
                        p.Name = bAse.Nom + j;
                        p.Text = bAse.Nom;
                        p.BackColor = ColoreBase(bAse);
                        p.Location = new Point(i * 15, j * 15);
                        soi.Controls.Add(p);
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
                    //longueur += 15;
                }
                soi.Size = new Size(longueur, 50);
                soi.Location = new System.Drawing.Point(0, 0);
            }
            private void ColoreGene(Gene gene, GGene soi)
            {
                Genon codonCouleur = gene.Sequence[0];
                int[] RGB = new int[3];
                for (int i = 0; i < codonCouleur.Paire.Length; i++)
                {
                    RGB[i] = ColorePaire(codonCouleur.Paire[i]);
                }
                soi.Size = new Size(150, 150);
                soi.BackColor = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
                soi.Location = new System.Drawing.Point(0, 50);

            }
            private void DoubleAffichage(Gene gene)
            {
                GGene ggene1 = new GGene(gene);
                ColoreGeneSplit(geneRecu, ggene1);
                GGene ggene2 = new GGene(gene);
                ColoreGene(geneRecu, ggene2);
                this.Controls.Add(ggene1);
                this.Controls.Add(ggene2);
                this.Size = ggene1.Size + ggene2.Size;
            }
            private Color ColoreBase(BaseAzotee bAse)
            {
                switch (bAse.Nom)
                {
                    case "A":
                        couleur = Color.Green;
                        break;
                    case "C":
                        couleur = Color.Red;
                        break;
                    case "G":
                        couleur = Color.Yellow;
                        break;
                    case "T":
                        couleur = Color.Magenta;
                        break;
                    default:
                        couleur = Color.Gray;
                        break;
                }
                return couleur;
            }

            private int ColorePaire(PaireDeBase paire)
            {
                int[] couleuR = new int[2];
                for (int i = 0; i < paire.Bases.Length;i++ )
                {
                    switch (paire.Bases[i].Nom)
                    {
                        case "A":
                            couleuR[i] = RandomGenerator.NombreAleatoire(50, 0);
                            break;
                        case "C":
                            couleuR[i] = RandomGenerator.NombreAleatoire(250, 200);
                            break;
                        case "G":
                            couleuR[i] = RandomGenerator.NombreAleatoire(200, 150);
                            break;
                        case "T":
                            couleuR[i] = RandomGenerator.NombreAleatoire(100, 50);
                            break;
                        default:
                            couleuR[i] = RandomGenerator.NombreAleatoire(150, 100);
                            break;
                    }
                }
                int ton = (couleuR[0] + couleuR[0] + couleuR[1]) / 3;
                return ton;
            }

            public void AfficheGene(Form fenetre, int typeAffichage = 0)
            {
                GGene soi = this;
                switch (typeAffichage)
                {
                    case 1:
                        ColoreGeneSplit(geneRecu, soi);
                        break;
                    case 2:
                        ColoreGene(geneRecu, soi);
                        break;
                    default:
                        DoubleAffichage(geneRecu);
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
