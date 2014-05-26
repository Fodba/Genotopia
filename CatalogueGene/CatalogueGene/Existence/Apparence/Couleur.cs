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
using CatalogueGene.Graphique;

namespace CatalogueGene
{
    namespace Existence
    {
        namespace Apparence
        {
            public class Couleur
            {
                public static void AfficheSequence(Gene gene, GGene soi)
                {
                    int longueur = 0;
                    soi.Controls.Clear();
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
                            p.Location = new Point((i * 15) + 5, (j * 15) + 5);
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
                                p.Location = new Point((i * 15) + decalage + 5, (j * 15) + 5);
                                soi.Controls.Add(p);
                            }
                            longueur += 15;
                        }
                        decalage += (genon.Paire.Length * 15)/* + 15*/;
                        //longueur += 15;
                    }
                    soi.Size = new Size(longueur + 10, 40);
                    //soi.Location = new System.Drawing.Point(0, 0);
                    soi.BackColor = Color.FromArgb(22, 22, 22);
                }


                public static int[] ColoreGene(Gene gene, GGene soi)
                {
                    Genon codonCouleur = gene.Sequence[0];
                    int[] RGB = new int[3];
                    for (int i = 0; i < codonCouleur.Paire.Length; i++)
                    {
                        RGB[i] = ColorePaire(codonCouleur.Paire[i]);
                    }
                    //soi.Size = new Size(20, 20);
                    //soi.BackColor = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
                    return RGB;
                    //soi.Location = new System.Drawing.Point(0, 50);
                }
                
                public static Color ColoreBase(BaseAzotee bAse)
                {
                    Color couleur;
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

                private static int ColorePaire(PaireDeBase paire)
                {
                    int[] couleuR = new int[2];
                    for (int i = 0; i < paire.Bases.Length; i++)
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
                    int ton = (couleuR[0] * 4 + couleuR[1]) / 5;
                    return ton;
                }
            }

        }
    }
}
