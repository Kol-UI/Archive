using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindRendu225107
{
    class PlateauDeJeu
    {
        public int[,] PlateauCorrection { get; set; } //deuxieme plateau, celui où l'ont vois si on a une couleur en commun avec le code couleur
        private int _ligne;
        private int _colonne;
        public string[,] Plateau { get; set; } //premier plateau, celui a gauche lorsqu'on joue

        public PlateauDeJeu(int ligne, int colonne)
        {
            Plateau = new string[ligne, colonne];
            PlateauCorrection = new int[ligne, colonne];
            _ligne = ligne;
            _colonne = colonne;
        }

        public void AffichagePlateau()
        {
            for (int i = 0; i < _ligne; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < _colonne; j++)
                {
                    if (Plateau[i, j] == "M") //condition pour l'affichage des couleurs sur le plateau de gauche
                    {
                        Console.Write("M ", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j] == "B")
                    {
                        Console.Write("B ", Console.ForegroundColor = ConsoleColor.Blue);
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j] == "V")
                    {
                        Console.Write("V ", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j] == "R")
                    {
                        Console.Write("R ", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j] == "C")
                    {
                        Console.Write("C ", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j] == "J")
                    {
                        Console.Write("J ", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("0 "); //les 0 représente l'absence de couleur choisie/il va etre de base sur le plateau
                    }
                }
                Console.Write("\t");
                for (int j = 0; j < _colonne; j++)
                {
                    if (PlateauCorrection[i, j] == 1) //condition pour l'affichage du plateau de gauche
                    {
                        Console.Write(".", Console.ForegroundColor = ConsoleColor.Blue);
                        Console.ResetColor();       //bleu pour signifier que c'est correct et au bon endroit
                    }
                    else if (PlateauCorrection[i, j] == 2)
                    {
                        Console.Write(".", Console.ForegroundColor = ConsoleColor.Magenta);
                        Console.ResetColor();       //magenta pour signifier que c'est correct mais pas au bon endroit
                    }
                    else if (PlateauCorrection[i, j] == 0)
                    {
                        Console.Write(".");     //de base/pour signifier que la couleur n'est pas présente
                    }

                }
                Console.Write("\n");
            }
        }

        public void UpdateTableau(List<string> selection, int tour)
        {
            for (int j = 0; j < _colonne; j++)
            {
                Plateau[tour, j] = selection[j];
            }
        }

        public void UpdateTableauCorrection(List<string> selection, List<string> Combinaison, int tour)
        {
            List<string> Combinaison2 = new List<string>();
            for (int i = 0; i < _colonne; i++)
            {
                Combinaison2.Add(Combinaison[i]);
            }
            int Compteur = 0;
            for (int j = 0; j < _colonne; j++)
            {
                if (selection[j] == Combinaison2[j]) //Comparaison un element avec un autre
                {                                       //entre la liste du code couleur et la liste du joueur qui doit deviner
                    PlateauCorrection[tour, Compteur] = 1;
                    Compteur++;
                    selection[j] = "w";//le w et le z ne seront normalement jamais utilisés, de meme 11 lignes plus bas
                    Combinaison2[j] = "z";
                }
            }
            for (int i = 0; i < _colonne; i++)
            {
                for (int j = 0; j < _colonne; j++)
                    if (selection[i] == Combinaison[j]) //Comparaison de tous les elements
                    {                                   //entre la liste du code couleur et la liste du joueur qui doit deviner
                        PlateauCorrection[tour, Compteur] = 2;
                        Compteur++;
                        selection[i] = "w";
                        Combinaison2[j] = "z";
                    }
            }
        }
    }
}
