using System;

namespace Labs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HelloWorld();
            FuncPourAdresse();
            AffichageBienvenue();
            ConditionCompteEnBanque();
            DireBonjour("Nicolas", 19);
            double valeur = LongueurHypothenuse(1, 3);
            Console.WriteLine("Le premier résultat est: " + valeur);
            valeur = LongueurHypothenuse(10, 10);
            Console.WriteLine("Le deuxième résultat est: " + valeur);
            Tableaux();
            DebutDuTP();
            ConditionsTP();
            FinDuTP();
            BoucleCompteur();
            BoucleForeach();
            BoucleWhile();
            BoucleWhileAvecBreak();
            DebutDuTP();
            CalculSommeEntiers();
            CalculMoyenne();
            CalculSommeIntersection();
            FinDuTP();

        }


        static void HelloWorld()
        {
            Console.WriteLine("\t\t\t\tHello world !");
        }

        static void FuncPourAdresse()
        {
            string codePostal = "14000";
            string ville = "Caen";
            string adresse = codePostal + " " + ville;
            Console.WriteLine("\t" + adresse);
        }

        static void ConditionCompteEnBanque()
        {
            decimal compteEnBanque = 300;
            if (compteEnBanque >= 0)
            {
                Console.WriteLine("\tVotre compte est créditeur");
                Console.WriteLine("\tVoici comment ouvrir un livret…");
            }
            else
            {
                Console.WriteLine("\tVotre compte est débiteur");
                Console.WriteLine("\tN’oubliez pas que les frais de découverts sont de …");
            }
        }

        static void AffichageBienvenue()
        {
            Console.WriteLine("Bonjour Nicolas");
            Console.WriteLine("-------" + Environment.NewLine);
            Console.WriteLine("\tBienvenue dans le monde merveilleux du C#" + Environment.NewLine);
        }

        static void DireBonjour(string prenom, int age)
        {
            Console.WriteLine(Environment.NewLine + "\tBonjour " + prenom + ". Vous avez " + age + " ans.");
        }

        static double LongueurHypothenuse(double a, double b)
        {
            Console.WriteLine(Environment.NewLine);
            double sommeDesCarres = a * a + b * b;
            double resultat = Math.Sqrt(sommeDesCarres);
            return resultat;
        }

        static void Tableaux()
        {
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine(Environment.NewLine + jours[3] + Environment.NewLine);
            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours[i]);
            }
        }

        static void DebutDuTP()
        {
            Console.WriteLine("\t\t\t\t----- Debut du TP -----");
        }

        static void FinDuTP()
        {
            Console.WriteLine("\t\t\t\t----- Fin du TP -----");
        }

        static void ConditionsTP()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                AfficherBonWeekEnd();
            }
            else
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
                {
                    AfficherBonWeekEnd();
                }
                else
                {
                    if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                    {
                        AfficherBonjour();
                    }
                    else
                    {
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 18)
                        {
                            AfficherBonWeekEnd();
                        }
                        else
                        {
                            AfficherBonsoir();
                        }
                    }
                }
            }
        }

        static void AfficherBonWeekEnd()
        {
            Console.WriteLine("Bon week-end " + Environment.UserName);
        }

        static void AfficherBonjour()
        {
            Console.WriteLine("Bonjour " + Environment.UserName);
        }

        static void AfficherBonsoir()
        {
            Console.WriteLine("Bonsoir " + Environment.UserName);
        }

        static void BoucleCompteur()
        {
            int compteur;
            for (compteur = 0; compteur < 6; compteur++)
            {
                Console.WriteLine("Bonjour C#" + compteur);
            }
        }

        static void BoucleForeach()
        {
            Console.WriteLine(Environment.NewLine);
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            foreach (string jour in jours)
            {
                Console.WriteLine("\t" + jour);
            }
        }

        static void BoucleWhile()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Yo C#");
                i++;
            }
        }

        static void BoucleWhileAvecBreak()
        {
            int k = 0;
            while (true)
            {
                if (k >= 50)
                {
                    break;
                }
                Console.WriteLine("Test du break avec un while");
                k++;
            }
        }

        static int CalculSommeEntiers(int borneMin, int borneMax)
        {
            int resultat = 0;
            for (int i = borneMin; i <= borneMax; i++)
            {
                resultat += i;
            }
            return resultat;
        }

        static double CalculMoyenne(List<double> liste)
        {
            double somme = 0;
            foreach (double valeur in liste)
            {
                somme += valeur;
            }
            return somme / liste.count;
        }

        static int CalculSommeIntersection()
        {
            List<int> multiplesDe3 = new List<int>();
            List<int> multiplesDe5 = new List<int>();

            for (int i = 3; i <= 100; i += 3)
            {
                multiplesDe3.Add(i);
            }
            for (int i = 5; i <= 100; i += 5)
            {
                multiplesDe5.Add(i);
            }

            int somme = 0;
            foreach (int m3 in multiplesDe3)
            {
                foreach (int m5 in multiplesDe5)
                {
                    if (m3 == m5)
                        somme += m3;
                }
            }
            return somme;
        }
    }
}