using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindRendu225107
{
    class Program
    {
        static void Main(string[] args)
        {
            bool modeDeJeuBool = false; int modeDeJeuChoix = -1;
            bool nbLigneBool = false; bool nbColonneBool = false; bool choixCouleur = false;
            int ligne = -1; int colonne = -1;
            List<string> Combinaison = new List<string>();
            bool enJeu = true;


            while (modeDeJeuChoix == 3 || modeDeJeuChoix == -1)
            {
                modeDeJeuChoix = ModeDeJeu(modeDeJeuBool, modeDeJeuChoix);
                // Les regles du jeu et les controles
                if (modeDeJeuChoix == 3)
                {
                    RegleDuJeu();
                    Console.WriteLine("Appuyez sur Entrée pour revenir sur le menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            // Le Mastermind en mode Joueur contre Ordinateur
            if (modeDeJeuChoix == 1)
            {
                Console.Clear();
                Console.WriteLine("\t\t-----Joueur contre Ordinateur-----\n\n");
                while (!nbLigneBool) //selection du nombre de ligne
                {
                    Console.Write("Veuillez choisir le nombre de ligne de votre plateau (maximum 20): ");
                    string testSaisieDeLigne = Console.ReadLine();
                    if (int.TryParse(testSaisieDeLigne, out ligne))
                    {
                        if (ligne > 0 && ligne < 21) // nombre de ligne de 1 a 20
                            nbLigneBool = true;
                    }
                }
                while (!nbColonneBool) //selection du nombre de colonne
                {
                    Console.Write("Veuillez choisir le nombre de colonne de votre plateau (maximum 7): ");
                    string testSaisieDeColonne = Console.ReadLine();
                    if (int.TryParse(testSaisieDeColonne, out colonne))
                    {
                        if (colonne > 0 && colonne < 8) // nombre de colonne de 1 a 7
                            nbColonneBool = true;
                    }
                }
                Console.Clear();
                int[] hasard = new int[colonne]; //random entre les six couleurs pour simuler l'ordinateur jouant contre le joueur
                Random aleatoire = new Random();
                for (int i = 0; i < colonne; i++)
                {
                    int nbAleatoire = aleatoire.Next(0, 6);
                    hasard[i] = nbAleatoire;
                }
                string innitialesCouleurs = "MBVRCJ";
                for (int i = 0; i < colonne; i++)
                {
                    Combinaison.Add(innitialesCouleurs.Substring(hasard[i], 1));
                }
                PlateauDeJeu Plateau = new PlateauDeJeu(ligne, colonne);
                int tour = ligne - 1;
                while (enJeu)
                {
                    Plateau.AffichagePlateau(); //a partir de la le jeu commence
                    List<string> selection = new List<string>();
                    Console.WriteLine("C'est maintenant votre tour de trouver le code couleur.\n Selectionner les couleurs:");
                    for (int i = 0; i < colonne; i++)
                        SelectionCouleur(choixCouleur, selection);
                    Console.Clear();
                    Plateau.UpdateTableau(selection, tour);
                    Plateau.UpdateTableauCorrection(selection, Combinaison, tour);
                    enJeu = VictoireOuDefaiteOrdinateur(tour, colonne, enJeu, Plateau);
                    tour--;
                }
                Console.ReadLine();
            }


            // Le MasterMind en mode Joueur contre Joueur
            else if (modeDeJeuChoix == 2)
            {
                Console.Clear();
                Console.WriteLine("\t\t-----Joueur contre Joueur-----\n\n");
                while (!nbLigneBool)
                {
                    Console.Write("Veuillez choisir le nombre de ligne de votre plateau (maximum 20): ");
                    string testSaisieDeLigne = Console.ReadLine();
                    if (int.TryParse(testSaisieDeLigne, out ligne))
                    {
                        if (ligne > 0 && ligne < 21) // nombre de ligne, pareil pour joueur contre ordinateur
                            nbLigneBool = true;
                    }
                }
                while (!nbColonneBool)
                {
                    Console.Write("Veuillez choisir le nombre de colonne de votre plateau (maximum 7): ");
                    string testSaisieDeColonne = Console.ReadLine();
                    if (int.TryParse(testSaisieDeColonne, out colonne))
                    {
                        if (colonne > 0 && colonne < 8) //nombre de colonne, pareil pour joueur contre ordinateur
                            nbColonneBool = true;
                    }
                }

                Console.WriteLine("Joueur 1: Veuillez choisir vos couleurs...");
                Console.WriteLine("M pour magenta", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                Console.WriteLine("B pour bleu", Console.ForegroundColor = ConsoleColor.Blue);
                Console.WriteLine("V pour vert", Console.ForegroundColor = ConsoleColor.Green);
                Console.WriteLine("R pour rouge", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("C pour cyan", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.WriteLine("J pour jaune\n", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.ResetColor();
                for (int i = 0; i < colonne; i++)
                {
                    SelectionCouleur(choixCouleur, Combinaison);
                }
                Console.Clear();
                PlateauDeJeu Plateau = new PlateauDeJeu(ligne, colonne);
                int tour = ligne - 1;
                while (enJeu)
                {
                    Plateau.AffichagePlateau();
                    List<string> selection = new List<string>();
                    Console.WriteLine("C'est maintenant au tour du joueur 2 de trouver le code couleur.\n Selectionner les couleurs:");
                    for (int i = 0; i < colonne; i++)
                        SelectionCouleur(choixCouleur, selection);
                    Console.Clear();
                    Plateau.UpdateTableau(selection, tour);
                    Plateau.UpdateTableauCorrection(selection, Combinaison, tour);
                    enJeu = VictoireOuDefaite(tour, colonne, enJeu, Plateau);
                    tour--;
                }
                Console.ReadLine();
            }
        }







        public static int ModeDeJeu(bool modeDeJeuBool, int modeDeJeuChoix) //boucles pour les modes de jeu
        {
            Console.WriteLine("\t\t-----MASTERMIND-----\n\n");
            while (!modeDeJeuBool)
            {
                Console.WriteLine("Choix du mode de jeu:\n\t1) Joueur contre Ordinateur\n\t2) Joueur contre Joueur\n\t3) Regles du jeu et Controles");
                string choixNbModeJeu = Console.ReadLine();
                if (int.TryParse(choixNbModeJeu, out modeDeJeuChoix))
                {
                    if (modeDeJeuChoix > 0 && modeDeJeuChoix < 4)
                    {
                        modeDeJeuBool = true;
                        switch (modeDeJeuChoix)
                        {
                            case 1: //mode de jeu 1 : joueur contre ordinateur
                                Console.WriteLine("Vous avez choisi le mode de jeu Joueur contre Ordinateur.\nAppuyez sur Entrée pour commencer...");
                                Console.ReadLine();
                                break;
                            case 2: //mode de jeu 2 : joueur contre joueur
                                Console.WriteLine("Vous avez choisi le mode de jeu Joueur contre Joueur.\nAppuyez sur Entrée pour commencer...");
                                Console.ReadLine();
                                break;
                            case 3: //acces aux regles pour jouer au mastermind
                                Console.WriteLine("Vous avez choisi d'acceder aux regles du jeu.\nAppuyez sur Entrée pour les lire...");
                                Console.ReadLine();
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        modeDeJeuBool = false;
                        Console.WriteLine("Le mode de jeu que vous avez selectionné n'est pas correct.");
                    }
                }
                else
                {
                    Console.Clear();
                    modeDeJeuBool = false;
                    Console.WriteLine("Le mode de jeu que vous avez selectionné n'est pas correct.");
                }
            }
            return modeDeJeuChoix;
        }




        public static List<string> SelectionCouleur(bool choixCouleur, List<string> list)
        {
            while (!choixCouleur) //ici se trouve la partie où on va ajouter les choix du joueur
            {                       //utilisé par les deux modes de jeu
                ConsoleKeyInfo toucheCouleur = Console.ReadKey(true);
                if (toucheCouleur.Key == ConsoleKey.M)  //M pour le magenta
                {
                    Console.Write("M", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                    Console.ResetColor();
                    list.Add("M");
                    break;
                }
                else if (toucheCouleur.Key == ConsoleKey.B) //B pour le bleu
                {
                    Console.Write("B", Console.ForegroundColor = ConsoleColor.Blue);
                    Console.ResetColor();
                    list.Add("B");
                    break;
                }
                else if (toucheCouleur.Key == ConsoleKey.V) //V pour le vert
                {
                    Console.Write("V", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                    list.Add("V");
                    break;
                }
                else if (toucheCouleur.Key == ConsoleKey.R) //R pour le rouge
                {
                    Console.Write("R", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    list.Add("R");
                    break;
                }
                else if (toucheCouleur.Key == ConsoleKey.C) //C pour le cyan
                {
                    Console.Write("C", Console.ForegroundColor = ConsoleColor.Cyan);
                    Console.ResetColor();
                    list.Add("C");
                    break;
                }
                else if (toucheCouleur.Key == ConsoleKey.J) //J pour le jaune
                {
                    Console.Write("J", Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.ResetColor();
                    list.Add("J");
                    break;
                }
            }
            return list;
        }


        public static void RegleDuJeu() //mode de jeu 3: les regles pour jouer
        {
            Console.Clear();
            Console.WriteLine("\t\t-----Regles et Controles du jeu-----\n\n");
            Console.WriteLine("\tRegles du jeu :");
            Console.WriteLine("Le but du jeu est de trouver le code couleur que l'autre joueur choisi au prealable.\n" +
                "Dans cette version du jeu, nous avons le choix entre six couleurs (magenta, bleu, vert, rouge, cyan et jaune).\n" +
                "De plus, le joueur peut choisir le nombre de ligne et de colonne.\n" +
                "les lignes representants les couleurs présentes dans le code et les colonnes représentants le nombre d'essai restant.\n" +
                "Le tableau de droite permet de voir si les couleurs selectionnées sont correctes ou non.\n" +
                "Le bleu signifie que vous avez trouvé la bonne couleur au bon endroit.\n" +
                "Le magenta signifie que vous avez trouvé une bonne couleur mais elle n'est pas au bon endroit.");
            Console.WriteLine("\n\tControles :");
            Console.WriteLine("M pour magenta", Console.ForegroundColor = ConsoleColor.DarkMagenta);
            Console.WriteLine("B pour bleu", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("V pour vert", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("R pour rouge", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("C pour cyan", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("J pour jaune\n", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
        }


        public static bool VictoireOuDefaite(int tour, int colonne, bool enJeu, PlateauDeJeu Plateau)
        {       //méthode pour gerer la victoire ou la defaite, dans le mode de jeu joueur contre joueur
            int Compter = 0;
            for (int i = 0; i < colonne; i++)
            {
                if (Plateau.PlateauCorrection[tour, i] == 1)
                {
                    Compter++;
                }
            }
            if (Compter == colonne)
            {
                Console.WriteLine("\n\n\t\t\t-----Le joueur 2 a trouvé le code couleur, il a donc gagné !-----");
                enJeu = false;
            }
            else if (tour == 0)
            {
                Console.WriteLine("\n\n\t\t\t-----Le joueur 1 a gagné car le joueur 2 ne possede plus d'essai !-----");
                enJeu = false;
            }
            return enJeu;

        }

        public static bool VictoireOuDefaiteOrdinateur(int tour, int colonne, bool enJeu, PlateauDeJeu Plateau)
        {       //méthode pour gerer la victoire et la defaite en joueur contre ordinateur
            int Compter = 0;
            for (int i = 0; i < colonne; i++)
            {
                if (Plateau.PlateauCorrection[tour, i] == 1)
                {
                    Compter++;
                }
            }
            if (Compter == colonne)
            {
                Console.WriteLine("\n\n\t\t\t-----Vous avez trouvé le code couleur, félicitations !-----");
                enJeu = false;
            }
            else if (tour == 0)
            {
                Console.WriteLine("\n\n\t\t\t-----Vous avez perdu car vous ne possedez plus d'essai !-----");
                enJeu = false;
            }
            return enJeu;

        }
    }
}
