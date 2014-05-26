using CatalogueGene.Genome;

namespace CatalogueGene
{
    namespace Console
    {
        public class Affichage
        {
            /// <summary>
            /// retourne une chaine de caractères en couleur.
            /// </summary>
            /// <param name="nom"></param>
            public static string Nom(string nom)
            {
                for (int i = 0; i < nom.Length; i++)
                {
                    switch (nom[i])
                    {
                        case 'A':
                           System.Console.ForegroundColor =System.ConsoleColor.Green;
                           System.Console.Write(nom[i]);
                            break;
                        case 'C':

                           System.Console.ForegroundColor =System.ConsoleColor.Red;
                           System.Console.Write(nom[i]);
                            break;
                        case 'G':

                           System.Console.ForegroundColor =System.ConsoleColor.Yellow;
                           System.Console.Write(nom[i]);
                            break;
                        case 'T':

                           System.Console.ForegroundColor =System.ConsoleColor.Magenta;
                           System.Console.Write(nom[i]);
                            break;
                        case 'U':

                           System.Console.ForegroundColor =System.ConsoleColor.Gray;
                           System.Console.Write(nom[i]);
                            break;
                        default:
                           System.Console.Write(" ");
                            break;
                    }
                }
                System.Console.Write("\n");
                System.Console.ForegroundColor =System.ConsoleColor.White;
                return nom;
            }
            /// <summary>
            /// retourne une double chaine de caractères colorée. 
            /// </summary>
            /// <param name="nom"></param>
            /// <param name="affiche"></param>
            /// <returns></returns>
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
            /// <summary>
            /// retourne le nom du Gene sous forme d'une double chaine de caractère colorée.
            /// </summary>
            /// <param name="gene"></param>
            public static string Gene(Gene gene,bool affiche=true)
            {
                string helice1 = Genon(gene.GenonActiveur.Nom, false)[0];
                string helice2 = Genon(gene.GenonActiveur.Nom, false)[1];
                string[] nomComplet = new string[2];

                helice1 += "\n";
                helice2 += "\n";

                helice1 += Genon(gene.Nom, false)[0];
                helice2 += Genon(gene.Nom, false)[1];

                
                nomComplet[0] = Nom(helice1);
                nomComplet[1] = Nom(helice2);
                if (affiche)
                {
                    System.Console.WriteLine();
                }
               return nomComplet[0];
            }
        }
    }
}
