using System;

// Fuzzy matching is a technique used to determine the similarity between two strings or to find approximate matches. There are various fuzzy matching algorithms available, and one popular algorithm is the Levenshtein distance algorithm.

public static class FuzzyMatching
{
    public static int LevenshteinDistanceForFuzzy(string source, string target)
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

    public static string FindBestMatch(string targetWord, List<string> wordList)
    { 
        string bestMatch = null;
        int bestDistance = int.MaxValue; 
        foreach (string word in wordList) 
        { 
            int distance = LevenshteinDistanceForFuzzy(targetWord, word);
            if (distance < bestDistance)
            { 
                bestDistance = distance;
                bestMatch = word;
            }
        }
        return bestMatch;
    }

    /*
        In the FindBestMatch function, the line "if (distance < bestDistance)" is used to determine if the calculated Levenshtein distance for a particular word is better (lower) than the current best distance.

        Here's how it works:

        distance represents the Levenshtein distance between the target word and the current word being evaluated.
        bestDistance holds the current best distance found so far in the list of words.
        Initially, bestDistance is set to a high value or positive infinity to ensure that the first distance calculated will be considered the best distance.

        When calculating the Levenshtein distance for each word in the list, the line "if (distance < bestDistance)" is used to check if the current distance is lower (better) than the current best distance. If it is, it means that the current word is a closer match to the target word.

        If the condition is true, the current word becomes the new best match, and its distance is updated as the new best distance (assigning bestDistance = distance). This process continues until all words in the list have been evaluated, and the best match is found.

        In summary, the line "if (distance < bestDistance)" is a comparison check to update the best distance and best match if a closer match is found during the iteration over the list of words.
    */

    public static void Example1()
    {
        List<string> wordList = new List<string> { "apple", "banana", "orange", "kiwi", "grape" };
        string targetWord = "aple";

        string bestMatch = FindBestMatch(targetWord, wordList);

        Console.WriteLine("Target Word: " + targetWord);
        Console.WriteLine("Best Match: " + bestMatch);
    }

    /*
        In this example, the FindBestMatch method takes a targetWord and a wordList as input. It iterates through each word in the wordList and calculates the Levenshtein distance between the targetWord and each word using the CalculateLevenshteinDistance method.
        It keeps track of the word with the lowest distance and returns it as the best match.

        In the Main method, we demonstrate the usage of the FindBestMatch method by providing a target word "aple" and a list of words.
        The method finds the word in the list that has the closest match to the target word based on the Levenshtein distance. The best match is then printed to the console.

        the best match for the target word "aple" will be "apple".
        The Levenshtein distance between "aple" and "apple" is 1, which is the lowest distance compared to other words in the list. Therefore, "apple" will be considered the best match.
    */

    // Case when we want multiple results :

    public static List<string> FindBestMatches(string searchTerm, List<string> wordList, int maxDistance)
    {
        List<string> bestMatches = new List<string>();
        int bestDistance = int.MaxValue;

        foreach (string word in wordList)
        {
            int distance = CalculateLevenshteinDistance(searchTerm, word);

            if (distance <= maxDistance)
            {
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                    bestMatches.Clear();
                    bestMatches.Add(word);
                }
                else if (distance == bestDistance)
                {
                    bestMatches.Add(word);
                }
            }
        }

        return bestMatches;
    }

    public static void Example2()
    { 
        List<string> wordList = new List<string>()
        {
            "apple", "banana", "cherry", "grape", "lemon", "mango", "orange", "peach", "strawberry", "watermelon"
        };
        string searchTerm = "ape";
        int maxDistance = 3;

        List<string> bestMatches = FuzzyMatching.FindBestMatches(searchTerm, wordList, maxDistance);

        Console.WriteLine($"Best Matches for '{searchTerm}':");
        if (bestMatches.Count > 0)
        {
            foreach (string match in bestMatches)
            {
                Console.WriteLine(match);
            }
        }
        else
        {
            Console.WriteLine("No matches found.");
        }
    }

    /*
    Output Best Matches for 'ape':
        apple
        grape
        peach
    */
}