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
using CatalogueGene.Existence.Vie.Organismes.Simples;
using CatalogueGene.Existence.Apparence;

namespace CatalogueGene
{
    namespace Existence
    {
        namespace Vie
        {
            namespace Habitat
            {
                public class Aire : Panel
                {
                    public Panel inventaire;
                    public Aire()
                    {
                        this.BackColor = Color.FromArgb(255, 255, 255);

                        this.Size = new Size(670, 670);
                        this.Location = new Point(140, 0);
                        this.inventaire = new Panel();
                        this.inventaire.Size = new Size(150, 670);
                        this.inventaire.Location = new Point(0, 0);
                    }

                    public void Peuplement(List<UniGene> etre)
                    {
                        Panel soi = this;
                        for (int i = 0; i < etre.Count(); i++)
                        {
                            etre[i].ggene2.AfficheGene(soi);
                        }
                    }
                    public void Inventaire(List<UniGene> peuple,out string liste)
                    {
                        int x = 0;
                        int y = 0;
                        liste = "";
                        this.inventaire.Controls.Clear();
                        for (int i = 0; i < peuple.Count(); i++)
                        {
                            Couleur.AfficheSequence(peuple[i].gEne, peuple[i].ggene1);
                            peuple[i].ggene1.Location = new Point(x, y);
                            this.inventaire.Controls.Add(peuple[i].ggene1);
                            y += 45;
                            liste += Affichage.Gene(peuple[i].gEne) + "\n";
                        }
                        //MessageBox.Show(liste);
                    }
                    public void AfficheEtres()
                    {
                        foreach (GGene item in this.Controls)
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }
        }
    }
}
