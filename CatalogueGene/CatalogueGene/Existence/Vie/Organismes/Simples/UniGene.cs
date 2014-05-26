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
using CatalogueGene.Existence.Apparence;
using CatalogueGene.Existence.Vie.Habitat;

namespace CatalogueGene
{
    namespace Existence
    {
        namespace Vie
        {
            namespace Organismes
            {
                namespace Simples
                {
                    public class UniGene
                    {
                        public Gene gEne;
                        public string Nom;
                        public GGene ggene1;
                        public GGene ggene2;
                        public int GG2x;
                        public int GG2y;
                        public UniGene()
                        {
                            this.GG2x = RandomGenerator.NombreAleatoire(395);
                            this.GG2y = RandomGenerator.NombreAleatoire(395);

                            gEne = new Gene(2);
                            this.Nom = Affichage.Gene(gEne, false);
                            ggene1 = new GGene(gEne);
                            ggene2 = new GGene(gEne);
                            int[] taille = Taille.DetermineTaille(gEne);
                            ggene2.Size = new Size(taille[0], taille[1]);

                            ggene2.Location = new Point(this.GG2x, this.GG2y);

                        }

                        public void Deplacement(int largeur, int hauteur)
                        {
                            switch (RandomGenerator.NombreAleatoire(4))
                            {
                                case 1:
                                    if (!(this.GG2x + 20 >= largeur))
                                    {
                                        this.GG2x += 5;
                                    }
                                    break;
                                case 2:
                                    if (!(this.GG2x <= 5))
                                    {
                                        this.GG2x -= 5;
                                    }
                                    break;
                                case 3:
                                    if (!(this.GG2y + 20 >= hauteur))
                                    {
                                        this.GG2y += 5;
                                    }
                                    break;
                                default:
                                    if (!(this.GG2y <= 5))
                                    {
                                        this.GG2y -= 5;
                                    }
                                    break;
                            }
                            this.ggene2.Location = new Point(this.GG2x, this.GG2y);
                        }
                    }
                }
            }
        }
    }
}
