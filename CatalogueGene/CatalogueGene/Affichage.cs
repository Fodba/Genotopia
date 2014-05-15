using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueGene
{
    public class Affichage
    {
        public static void Nom(string nom)
        {
            for (int i = 0; i < nom.Length; i++)
            {
                switch (nom[i])
                {
                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(nom[i]);
                        break;
                    case 'C':

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(nom[i]);
                        break;
                    case 'G':
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(nom[i]);
                        break;
                    case 'T':
                        
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(nom[i]);
                        break;
                    case 'U':
                        
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(nom[i]);
                        break;
                    default:
                        Console.Write(" ");
                        break;
                }
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string[] Genon(string nom, bool affiche = true)
        {
            string helice1 = "";
            string helice2 = "";
            for (int i = 0; i < nom.Length; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    helice1 += nom[i];
                }
                else
                {
                    helice2 += nom[i];
                }
            }
            if (affiche)
            {
                Nom(helice1);
                Nom(helice2);
            }
            string[] tab = new string[2];
            tab[0] = helice1;
            tab[1] = helice2;
            return tab;
        }
        public static void Gene(Gene gene)
        {
            string helice1 = Genon(gene.GenonActiveur.Nom, false)[0];
            string helice2 = Genon(gene.GenonActiveur.Nom, false)[1];

            helice1 += " ";
            helice2 += " ";

            helice1 += Genon(gene.Nom, false)[0];
            helice2 += Genon(gene.Nom, false)[1];

            Nom(helice1);
            Nom(helice2);
            Console.WriteLine();
            

        }
    }
}
