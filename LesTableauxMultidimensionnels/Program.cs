using System;
using System.ComponentModel.Design;

namespace LesTableauxMultidimensionnels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabUniforme = new int[3, 3]
            {
                 {1,2,3},
                 {2,3,4},
                 {3,4,5},
            };
            int[][] tabIrregulier = new int[3][];

            tabIrregulier[0] = new int[3];
            for (int i = 0; i < tabIrregulier[0].Length; i++)
            {
                tabIrregulier[0][i] = tabUniforme[0,i] ;
            }

            tabIrregulier[1] = new int[2];
            for (int i = 0; i < tabIrregulier[1].Length; i++)
            {
                tabIrregulier[1][i] = tabUniforme[1, i+1];
            }

            tabIrregulier[2] = new int[1];
            for (int i = 0; i < tabIrregulier[2].Length; i++)
            {
                tabIrregulier[2][i] = tabUniforme[2, i+2];
            }
            Console.WriteLine("Tableau uniforme : ");
            for (int i = 0; i < 3; i++) 
            {
                Console.Write(" [ " + i + " => ");
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(tabUniforme[i, j] + " "); 
                }
                Console.WriteLine("]");
            }

            Console.WriteLine();

            Console.WriteLine("Tableau irregulier : ");
            for (int i = 0; i < tabIrregulier.Length; i++)
            {
                Console.Write(" [ " +(i)+ " => ");
                for (int j = 0; j < tabIrregulier[i].Length; j++)
                {
                    Console.Write(tabIrregulier[i][j] + " "); 
                }
                Console.WriteLine("]"); 
            }
        }
    }
}
