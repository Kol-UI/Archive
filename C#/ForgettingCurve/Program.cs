using System;

public class ForgettingCurve
{
    public static void Main()
    {
        /*
        DateTime now = DateTime.Now;
        DateTime due = new DateTime(2023, 11, 7, 14, 0, 0);
        double testNextRevisionHours = (due - now).TotalHours;

        Console.WriteLine($"Prochaine révision dans {testNextRevisionHours} heures");

        DateTime lastReview = new DateTime(2023, 3, 1, 10, 0, 0);
        double testElapsedTimeInDays = (now - lastReview).TotalDays;

        Console.WriteLine($"Dernière révision il y a {testElapsedTimeInDays} hours.");
        */


        Console.WriteLine("");
        //double nextRevisionHours = testNextRevisionHours;
        //double elapsedTimeInHours = testElapsedTimeInHours;
        double nextRevisionHours = 1; // J4 (HEURES)
        //if (nextRevisionHours < 0) nextRevisionHours = 0.1;
        double elapsedTimeInDays = 0.4; // G11 (JOURS)
        //if (elapsedTimeInDays < 0) elapsedTimeInDays = 0;

        Console.WriteLine($"heures  : {nextRevisionHours}");
        double forget90 = nextRevisionHours / 24.0f; // H5
        Console.WriteLine($"oubli 90% à  : {forget90}");
        double time = forget90 * 24.0f; // J5
        Console.WriteLine($"J5  : {time}");
        double retention = -time / Math.Log(0.9); // H8
        Console.WriteLine($"retention  : {retention}");
        double result = Math.Exp(-elapsedTimeInDays / retention); // H11
        Console.WriteLine($"resultat : {result}");

        result *= 100;
        if (result > 100) result = 0;
        Console.WriteLine($"score : {result} %");
        //result = Math.Round(result, 2);
        //Console.WriteLine($"score : {result} %");

        






        /*

        double initialPercentage = 100; // Pourcentage de connaissance initial
        double forgettingRate = 0.1; // Taux d'oubli
        double elapsedTimeInHours = 1; // Temps écoulé depuis la dernière révision (en heures)

        double elapsedTimeInDays = nextRevisionHours / 24.0f; // G11
        double forgettingValue = elapsedTimeInHours / 24.0f; // H5
        double time = forgettingValue * 24.0f; // J5
        Console.WriteLine($"oubli 90% à  : {forgettingValue}");
        Console.WriteLine($"jours  : {time}");
        double retention = (-time) / Math.Log(0.9); // H8
        Console.WriteLine($"retention : {retention}");
        double result = Math.Exp(-elapsedTimeInDays / retention); // H11
        Console.WriteLine($"resultat : {result}");
        */








        //double knowledgePercentage = CalculateKnowledgePercentage(initialPercentage, elapsedTimeInHours, forgettingRate);
        Console.WriteLine();
        //Console.WriteLine($"Heures : {elapsedTimeInHours}   Pourcentage de connaissance : {knowledgePercentage}%");


        // TEST
        /*
        for (int i = 0; i < 24; i++)
        {
            elapsedTimeInHours++;
            double knowledgePercentage2 = CalculateKnowledgePercentage(initialPercentage, elapsedTimeInHours, forgettingRate);
            Console.WriteLine($"Heures : {elapsedTimeInHours}   Pourcentage de connaissance : {knowledgePercentage2}%");
        }
        */
    }

    private static double CalculateKnowledgePercentage(double initialPercentage, double elapsedTimeInHours, double forgettingRate)
    {
        double elapsedTimeInDays = elapsedTimeInHours / 24.0;
        double knowledgePercentage = initialPercentage * Math.Exp(-forgettingRate * elapsedTimeInDays);
        // Or double knowledgePercentage = initialPercentage * Math.Pow(Math.E, -forgettingRate * elapsedTimeInDays);
        return knowledgePercentage;
    }
}