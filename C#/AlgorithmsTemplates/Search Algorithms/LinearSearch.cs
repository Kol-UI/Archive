using System;

public static class LinearSearch 
{
    /*
        ## Fonctionnement
        Linear Search consiste simplement à parcourir séquentiellement tous les éléments du tableau jusqu'à trouver la valeur recherchée.
        Elle permet de parcourir tous les éléments du tableau et de stocker les indices correspondants.

        ## Complexité
        La complexité de l'algorithme Linear Search est linéaire, notée O(n), où n est la taille du tableau.

        Cela signifie que le temps d'exécution de l'algorithme augmente de manière linéaire avec la taille du tableau.
        Dans le pire des cas, lorsque la valeur recherchée est à la fin du tableau ou n'est pas présente du tout, il faut parcourir tous les éléments du tableau, ce qui nécessite n comparaisons.

        En termes de complexité, l'algorithme Linear Search est simple mais relativement inefficace pour les grandes quantités de données.
        Si vous avez un tableau trié, il est préférable d'utiliser l'algorithme Binary Search qui a une complexité logarithmique, notée O(log n), et est plus efficace pour la recherche dans des tableaux triés.

        ## Implémentation
        La fonction `LinearSearch` parcourt séquentiellement chaque élément du tableau `arr` et vérifie s'il correspond à la valeur cible `target`.
        Si une correspondance est trouvée, la fonction retourne l'indice de la première occurrence de la valeur. Si la valeur n'est pas trouvée, la fonction retourne -1.
    */    

    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Retourne l'indice de la première occurrence de la valeur recherchée
            }
        }
        
        return -1; // Retourne -1 si la valeur n'est pas trouvée dans le tableau
    }

    /*
        ## L'appel
        ```C#
        int[] numbers = { 5, 2, 9, 1, 7, 4 };

        int target = 7;
        int index = LinearSearch(numbers, target);

        if (index != -1)
        {
            Console.WriteLine("La valeur {0} a été trouvée à l'indice {1}.", target, index);
        }
        else
        {
            Console.WriteLine("La valeur {0} n'a pas été trouvée dans le tableau.", target);
        }
        ```
    */

    // Descending
    public static int LinearSearchDescending(int[] arr, int target)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == target)
            {
                return i; // Renvoie l'indice de la première occurrence de la valeur cible
            }
        }

        return -1; // Renvoie -1 si la valeur n'est pas trouvée dans le tableau
    }

    /*
        Dans cette version modifiée, nous commençons la boucle depuis la fin du tableau (`arr.Length - 1`)
        et décrémentons `i` de 1 à chaque itération jusqu'à ce que `i` atteigne 0.
        Cela nous permet de rechercher la valeur cible dans l'ordre décroissant.
    */

    /*
        ## Avec plusieurs occurrences
    */
    public static List<int> LinearSearchMultiple(int[] arr, int target)
    {
        List<int> indices = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                indices.Add(i);
            }
        }

        return indices;
    }

    /*
        ## L'appel
        ```C#
        int[] numbers = { 5, 9, 3, 7, 2, 8, 1, 7 };
        int target = 7;

        List<int> indices = LinearSearchMultiple(numbers, target);

        if (indices.Count > 0)
        {
            Console.WriteLine("La cible a été trouvée aux indices suivants :");

            foreach (int index in indices)
            {
                Console.WriteLine(index);
            }
        }
        else
        {
            Console.WriteLine("La cible n'a pas été trouvée dans le tableau.");
        }
        ```
    */

    // Descending + Multiple
    public static List<int> LinearSearchMultipleDescending(int[] arr, int target)
    {
        List<int> indices = new List<int>();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == target)
            {
                indices.Add(i);
            }
        }

        indices.Reverse(); // Inverse la liste pour maintenir l'ordre décroissant des indices

        return indices;
    }
}
