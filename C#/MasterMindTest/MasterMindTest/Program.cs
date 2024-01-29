using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30; string prenom = "Nicolas"; string codePostal = "14000"; string ville = "Caen"; string rue = "6731 Rue Kappa"; int compteur = 1;
            bool ageIsValid = false; int ageSaisie = -1;
            bool bonneCouleur1 = false; bool bonneCouleur2 = false; bool bonneCouleur3 = false; int couleur1 = -1; int couleur2 = -1; int couleur3 = -1;
            string choixCouleur = "(1 bleu, 2 vert, 3 rouge, 4 jaune, 5 blanc, 6 noir)";
            int[] tableau = new int[4];

            Console.WriteLine("choisis le nombre de ligne pd");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("choisis le nombre de colonnes pd");
            int c = int.Parse(Console.ReadLine());
            Char[,] array = new Char[l, c];
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                    array[i, j] = '.';
            }
            Console.Write("appuie pour afficher le plateau");
            Console.ReadLine();
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write(array[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();


            ConditionJour(prenom);
            InformationsUtiles(prenom, codePostal, ville, rue, age);
            CompteurMultiplicite(compteur);
            SaisirAge(ageIsValid, ageSaisie);
            SaisirCouleur(bonneCouleur1, bonneCouleur2, bonneCouleur3, couleur1, couleur2, couleur3, choixCouleur);

        }

        static void InformationsUtiles(string prenom, string codePostal, string ville, string rue, int age)
        {
            Console.WriteLine("\n\tInformations utiles :\n\t\t-Le code postal : " + codePostal + "\n\t\t-La ville : "
                + ville + "\n\t\t-La rue : " + rue + "\n\t\t-Le prenom : " + prenom + "\n\t\t-L'age : " + age + "\n");
        }

        static void BonWeekEnd(string prenom)
        {
            Console.WriteLine("Bon week-end " + prenom);
        }

        static void AfficherBonsoir(string prenom)
        {
            Console.WriteLine("Bonsoir " + prenom);
        }

        static void AfficherBonjour(string prenom)
        {
            Console.WriteLine("Bonjour " + prenom);
        }

        static void CompteurMultiplicite(int compteur)
        {
            for (compteur = 1; compteur < 6; compteur++)
                Console.WriteLine("Bonjour C#" + compteur);
        }
        static void ConditionJour(string prenom)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                BonWeekEnd(prenom);
            }
            else
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
                {
                    AfficherBonjour(prenom);
                }
                else
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 18)

                    {
                        BonWeekEnd(prenom);
                    }
                    else
                    {
                        AfficherBonsoir(prenom);
                    }
                }
            }
        }

        static void SaisirAge(bool ageIsValid, int ageSaisie)
        {
            while (!ageIsValid)
            {
                Console.WriteLine("Veuillez saisir votre age");
                string saisie = Console.ReadLine();
                if (int.TryParse(saisie, out ageSaisie))
                    ageIsValid = true;
                else
                {
                    ageIsValid = false;
                    Console.WriteLine("L'age que vous avez saisi est incorrect...");
                }
            }
            Console.WriteLine("Votre âge est de : " + ageSaisie);
        }

        static void SaisirCouleur(bool bonneCouleur1, bool bonneCouleur2, bool bonneCouleur3, int couleur1, int couleur2, int couleur3, string choixCouleur)
        {
            while (!bonneCouleur1)
            {
                Console.WriteLine("Veuillez choisir la premiere couleur" + choixCouleur);
                string saisirCouleur = Console.ReadLine();
                if (int.TryParse(saisirCouleur, out couleur1))
                    bonneCouleur1 = true;
                else
                {
                    bonneCouleur1 = false;
                    Console.WriteLine("La couleur que vous avez saisi est incorrect...");
                }
            }
            switch (couleur1)
            {
                case 1:
                    Console.WriteLine("La premiere couleur est donc le bleu");
                    break;
                case 2:
                    Console.WriteLine("La premiere couleur est donc le vert");
                    break;
                case 3:
                    Console.WriteLine("La premiere couleur est donc le rouge");
                    break;
                case 4:
                    Console.WriteLine("La premiere couleur est donc le jaune");
                    break;
                case 5:
                    Console.WriteLine("La premiere couleur est donc le blanc");
                    break;
                case 6:
                    Console.WriteLine("La premiere couleur est donc le noir");
                    break;
            }

            while (!bonneCouleur2)
            {
                Console.WriteLine("Veuillez choisir la premiere couleur" + choixCouleur);
                string saisirCouleur = Console.ReadLine();
                if (int.TryParse(saisirCouleur, out couleur2))
                    bonneCouleur2 = true;
                else
                {
                    bonneCouleur2 = false;
                    Console.WriteLine("La couleur que vous avez saisi est incorrect...");
                }
            }
            switch (couleur2)
            {
                case 1:
                    Console.WriteLine("La premiere couleur est donc le bleu");
                    break;
                case 2:
                    Console.WriteLine("La premiere couleur est donc le vert");
                    break;
                case 3:
                    Console.WriteLine("La premiere couleur est donc le rouge");
                    break;
                case 4:
                    Console.WriteLine("La premiere couleur est donc le jaune");
                    break;
                case 5:
                    Console.WriteLine("La premiere couleur est donc le blanc");
                    break;
                case 6:
                    Console.WriteLine("La premiere couleur est donc le noir");
                    break;
            }

            while (!bonneCouleur3)
            {
                Console.WriteLine("Veuillez choisir la premiere couleur" + choixCouleur);
                string saisirCouleur = Console.ReadLine();
                if (int.TryParse(saisirCouleur, out couleur3))
                    bonneCouleur3 = true;
                else
                {
                    bonneCouleur3 = false;
                    Console.WriteLine("La couleur que vous avez saisi est incorrect...");
                }
            }
            switch (couleur3)
            {
                case 1:
                    Console.WriteLine("La premiere couleur est donc le bleu");
                    break;
                case 2:
                    Console.WriteLine("La premiere couleur est donc le vert");
                    break;
                case 3:
                    Console.WriteLine("La premiere couleur est donc le rouge");
                    break;
                case 4:
                    Console.WriteLine("La premiere couleur est donc le jaune");
                    break;
                case 5:
                    Console.WriteLine("La premiere couleur est donc le blanc");
                    break;
                case 6:
                    Console.WriteLine("La premiere couleur est donc le noir");
                    break;
            }
        }
    }
}