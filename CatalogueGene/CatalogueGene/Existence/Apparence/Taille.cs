using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueGene.Genome;
using CatalogueGene.Graphique;
using CatalogueGene.Fonctions;

namespace CatalogueGene.Existence.Apparence
{
    public abstract class Taille
    {
        public static int[] DetermineTaille(Gene gene)
        {
            int compteur = 0;
            Genon codonCouleur = gene.Sequence[1];
            int[] RGB = new int[2];
            int somme1 = 0;
            int somme2 = 0;
            int resultat1 = 0;
            int resultat2 = 0;
            for (int i = 0; i < codonCouleur.Paire.Length; i++)
            {
                for (int j = 0; j < codonCouleur.Paire[i].Bases.Length; j++)
                {
                    switch (codonCouleur.Paire[i].Bases[j].Nom)
                    {
                        case "A":
                            if (j == 0)
                            {
                                somme1 += (RandomGenerator.NombreAleatoire(25, 5) * 2);
                            }
                            else {
                                somme2 += RandomGenerator.NombreAleatoire(25, 5);
                            }
                            break;
                        case "T":
                            if (j == 0)
                            {
                                somme1 += RandomGenerator.NombreAleatoire(25, 5);
                            }
                            else
                            {
                                somme2 += RandomGenerator.NombreAleatoire(25, 5);
                            }
                            break;
                        case "C":
                            if (j == 0)
                            {
                                somme1 += (RandomGenerator.NombreAleatoire(25, 5) * 2);
                            }
                            else
                            {
                                somme2 += RandomGenerator.NombreAleatoire(50, 25);
                            }
                            break;
                        case "G":
                            if (j == 0)
                            {
                                somme1 += RandomGenerator.NombreAleatoire(50, 25);
                            }
                            else
                            {
                                somme2 += RandomGenerator.NombreAleatoire(50, 25);
                            }
                            break;
                    }
                    compteur++;
                }
            }
            resultat1 = somme1 / 3;
            resultat2 = somme2 / 3;
            RGB[0]=resultat1;
            RGB[1]=resultat2;
            return RGB; 
        }
    }
}
