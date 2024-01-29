using System;

// The Levenshtein distance algorithm is used to measure the difference between two strings. It calculates the minimum number of operations required to transform one string into another, where the operations can be insertion, deletion, or substitution of a character.

public static class LevenshreinDistance
{
    // Passing two strings as parameters, and it will return the Levenshtein distance between them.
    public static int CalculateLevenshteinDistance(string source, string target)
    {
        int sourceLength = source.Length;
        int targetLength = target.Length;

        int[,] distance = new int[sourceLength + 1, targetLength + 1];

        // Initialize the distance matrix
        for (int i = 0; i <= sourceLength; i++)
            distance[i, 0] = i;
        for (int j = 0; j <= targetLength; j++)
            distance[0, j] = j;

        // Calculate the minimum number of operations
        for (int i = 1; i <= sourceLength; i++)
        {
            for (int j = 1; j <= targetLength; j++)
            {
                int cost = (source[i - 1] == target[j - 1]) ? 0 : 1;

                distance[i, j] = Math.Min(
                    Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1),
                    distance[i - 1, j - 1] + cost);
            }
        }

        // Return the Levenshtein distance
        return distance[sourceLength, targetLength];
    }

    // Here's an other way to write it :
    public static int LevenshteinDistance(string source, string target)
    {
        int sourceLength = source.Length;
        int targetLength = target.Length;

        // Create a matrix to store the Levenshtein distances
        int[,] distanceMatrix = new int[sourceLength + 1, targetLength + 1];

        // Initialize the matrix
        for (int i = 0; i <= sourceLength; i++)
            distanceMatrix[i, 0] = i;
        for (int j = 0; j <= targetLength; j++)
            distanceMatrix[0, j] = j;

        // Compute the Levenshtein distances
        for (int i = 1; i <= sourceLength; i++)
        {
            for (int j = 1; j <= targetLength; j++)
            {
                int cost = (source[i - 1] == target[j - 1]) ? 0 : 1;
                int deletion = distanceMatrix[i - 1, j] + 1;
                int insertion = distanceMatrix[i, j - 1] + 1;
                int substitution = distanceMatrix[i - 1, j - 1] + cost;

                distanceMatrix[i, j] = Math.Min(Math.Min(deletion, insertion), substitution);
            }
        }

        // Return the Levenshtein distance between the two strings
        return distanceMatrix[sourceLength, targetLength];
    }

    /*
    The Levenshtein distance algorithm has various use cases and can be helpful in several scenarios, including:

    Spell Checking and Auto Correction: It can be used to suggest corrections for misspelled words by finding words with a low Levenshtein distance from the input word.

    Text Comparison: It can be used to compare two texts or documents and determine their similarity by calculating the Levenshtein distance between them.

    DNA Sequence Analysis: It can be used in bioinformatics to analyze DNA sequences and measure the similarity or difference between them.

    Data Cleansing and Deduplication: It can be used to identify and merge duplicate records in databases by calculating the distance between the values of certain fields.

    Natural Language Processing: It can be used in various natural language processing tasks, such as machine translation, sentiment analysis, and information retrieval.

    Overall, the Levenshtein distance algorithm provides a quantitative measure of the difference between strings, allowing for various applications in fields like text processing, data analysis, and computational biology.
    */


    // Example :

    public static void ExampleLevenshteinDistance()
    {
        string source = "kitten";
        string target = "sitting";
        int distance = CalculateLevenshteinDistance(source, target);
        // Or int distance = LevenshteinDistance(source, target);
        Console.WriteLine("Levenshtein Distance: " + distance);
    }

    /*
        In this example, the CalculateLevenshteinDistance method takes two strings source and target as input and calculates the Levenshtein distance between them. The Levenshtein distance is the minimum number of single-character edits (insertions, deletions, or substitutions) required to transform the source string into the target string.

        In the method, we demonstrate the usage of the CalculateLevenshteinDistance method by calculating the Levenshtein distance between the strings "kitten" and "sitting". The result is printed to the console.
        
        The Levenshtein distance between the source string "kitten" and the target string "sitting" is 3. This means that it takes a minimum of 3 operations (insertions, deletions, or substitutions) to transform the source string into the target string.

    */




} 