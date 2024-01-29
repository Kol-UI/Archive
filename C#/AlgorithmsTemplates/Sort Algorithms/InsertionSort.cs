using System;

public static class InsertionSort 
{
    // Insertion Sort
    /*
        ## Fonctionnement
        Il fonctionne en construisant progressivement une séquence triée en insérant chaque élément non trié à sa place appropriée dans la séquence triée précédente.

        ## Implémentation
    */
    public static void InsertionSort(int[] array)
    {
        int n = array.Length;
        
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;
            
            // Déplacement des éléments plus grands que la clé vers la droite
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            
            // Insertion de la clé à sa position correcte
            array[j + 1] = key;
        }
    }

    /*

        ## Explications
        L'algorithme commence par considérer le deuxième élément du tableau (indice 1) comme étant le premier élément non trié.
        Il compare ensuite cet élément à tous les éléments précédents dans la séquence triée et les déplace vers la droite si nécessaire, afin de faire de la place pour insérer l'élément à sa position correcte.
        Ce processus est répété pour tous les éléments non triés jusqu'à ce que tout le tableau soit trié.

        ## Complexité & Utilisation
        L'algorithme Insertion Sort est particulièrement efficace pour de petites tailles de tableau ou lorsque le tableau est déjà partiellement trié.
        Cependant, il a une complexité temporelle de O(n^2), ce qui le rend moins efficace pour de grands tableaux comparé à des algorithmes de tri plus rapides comme le tri fusion (Merge Sort) ou le tri rapide (Quick Sort).

        L'Insertion Sort peut être utilisé lorsque l'ordre initial des éléments est important, car il effectue des échanges d'éléments adjacents plutôt que des permutations complètes.
        Cependant, si vous avez besoin d'un algorithme de tri plus performant pour des tableaux de grande taille, il est préférable d'utiliser d'autres algorithmes de tri plus efficaces.

        ## Etapes
        1. Parcourir le tableau à partir de l'indice 1 jusqu'à la fin.
        2. Pour chaque élément non trié, le considérer comme une clé.
        3. Comparer la clé avec les éléments précédents dans la séquence triée.
        4. Déplacer les éléments plus grands que la clé vers la droite pour faire de la place.
        5. Insérer la clé à sa position correcte dans la séquence triée.
        6. Répéter les étapes 2 à 5 pour tous les éléments non triés.
        7. Le tableau est maintenant trié.

        Exemple de l'algorithme Insertion Sort avec un tableau [7, 2, 4, 1, 5] :

        Étape 1: [**7**, 2, 4, 1, 5] (7 est considéré comme la clé)
        Étape 2: [2, **7**, 4, 1, 5] (7 est inséré à sa position correcte)
        Étape 3: [2, 7, **4**, 1, 5] (4 est considéré comme la clé)
        Étape 4: [2, **4**, 7, 1, 5] (4 est inséré à sa position correcte)
        Étape 5: [2, 4, 7, **1**, 5] (1 est considéré comme la clé)
        Étape 6: [2, 4, **1**, 7, 5] (1 est inséré à sa position correcte)
        Étape 7: [2, **1**, 4, 7, 5] (1 est inséré à sa position correcte)
        Étape 8: [**1**, 2, 4, 7, 5] (1 est inséré à sa position correcte)
        Étape 9: [1, 2, 4, **5**, 7] (5 est considéré comme la clé)
        Étape 10: [1, 2, **5**, 4, 7] (5 est inséré à sa position correcte)
        Étape 11: [1, **2**, 5, 4, 7] (2 est inséré à sa position correcte)
        Étape 12: [**1**, 2, 5, 4, 7] (1 est inséré à sa position correcte)
        Étape 13: [1, 2, 5, 4, 7] (le tableau est trié)
    */


    //  InsertionSort
    // We still check items one by one what we instead do is “insert” the item at the correct index

    // Unlike BubbleSort where we are swapping the item with it’s neighbour,
    // we are instead inserting the item into the correct position given what we have already checked.

    // Privilege Insertion sort over the divide and conquer sorting algorithms like merge sort and quick sort
    // When the problem is small /!\

    // The O(N^2) one will be faster than the O(N Log N) one until about N = 9000 entries or so
    // InsertionSort O(n^2) | QuickSort O(n log n)

    // Typical InsertionSort
    static void InsertionSort(int[] input)
    {
        // We loop through each item in the index and get the value
        for (int i = 0; i < input.Count(); i++)
        {
            var item = input[i];
            var currentIndex = i;

            // Then we loop through each item in the indexes *below* the index we started at.
            while (currentIndex > 0 && input[currentIndex - 1] > item)
            {
                // If the item has a lower value than the index below them, then we “shift” that item below them up by 1.
                input[currentIndex] = input[currentIndex - 1];
                currentIndex--;
                // And check the next item
                // In a way it’s like a bubble sort because we are comparing the neighbour below them,
                    // But if we do swap, then we continue swapping until we get to the end.
            }

            // If we get to the last index (0), or we hit a new item that has a lower value than our current item
            // Then we “break” and simple insert our current item at that index.
            input[currentIndex] = item;
        }
    }

    // But a simpler way to view the “Insertion” sort algorithm is actually by building a new list to return

    // New List InsertionSort
    static List<int> InsertionSortNew(this List<int> input)
    {
        // We Create a new list
        // Where we slowly add items to it by inserting them at the correct location
        var clonedList = new List<int>(input.Count);

        for (int i = 0; i < input.Count; i++)
        {
            var item = input[i];
            var currentIndex = i;

            while (currentIndex > 0 && clonedList[currentIndex - 1] > item)
            {
                currentIndex--;
            }

            // C# take care of the insertion into the new list
            clonedList.Insert(currentIndex, item);
        }

        return clonedList;
    }


    // Descending
    public static void InsertionSortDescending(int[] array)
    {
        int n = array.Length;
        
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;
            
            // Déplacement des éléments plus petits que la clé vers la droite
            while (j >= 0 && array[j] < key) // Inverser la condition pour l'ordre descendant
            {
                array[j + 1] = array[j];
                j--;
            }
            
            // Insertion de la clé à sa position correcte
            array[j + 1] = key;
        }
    }
}