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
                }
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
