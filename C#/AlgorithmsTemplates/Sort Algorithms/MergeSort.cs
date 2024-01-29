using System;

public static class MergeSort 
{
    /*
    ## Fonctionnement
    L'algorithme Merge Sort est un algorithme de tri basé sur la technique de diviser pour régner. Il divise récursivement la liste en sous-listes plus petites, les trie individuellement, puis les fusionne pour obtenir une liste triée.

    Cela permet de diviser progressivement la liste en sous-listes plus petites jusqu'à ce que chaque sous-liste ne contienne qu'un seul élément (cas de base), puis de les fusionner en une liste triée à l'aide de la fonction Merge.

    ## Etapes
    1. Diviser la liste en deux parties égales jusqu'à ce que chaque partie contienne un seul élément (cas de base).
    2. Récursivement, trier chaque moitié de la liste en appliquant le Merge Sort.
    3. Fusionner les deux moitiés triées en une seule liste triée.

    ## Implémentation
    */

    public static void MergeSort(int[] arr, int low, int high)
    {
        // low : indice du premier élément de la partie non trié
        // high : indice du dernier élément de la partie non trié
        if (low < high)
        {
            int middle = (low + high) / 2;
            MergeSort(arr, low, middle); // Trier la première moitié de la liste
            MergeSort(arr, middle + 1, high); // Trier la deuxième moitié de la liste
            Merge(arr, low, middle, high); // Fusionner les deux moitiés triées
        }
    }

    public static void Merge(int[] arr, int low, int middle, int high)
    {
        int n1 = middle - low + 1; // Taille de la première moitié
        int n2 = high - middle; // Taille de la deuxième moitié

        // Créer des tableaux temporaires pour stocker les sous-tableaux
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        // Copier les éléments dans les sous-tableaux temporaires
        for (int i = 0; i < n1; i++)
            leftArr[i] = arr[low + i];
        for (int j = 0; j < n2; j++)
            rightArr[j] = arr[middle + 1 + j];

        // Fusionner les sous-tableaux en une seule liste triée
        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = low;

        while (leftIndex < n1 && rightIndex < n2)
        {
            if (leftArr[leftIndex] <= rightArr[rightIndex])
            {
                arr[mergedIndex] = leftArr[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[mergedIndex] = rightArr[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        // Copier les éléments restants du sous-tableau gauche s'il y en a
        while (leftIndex < n1)
        {
            arr[mergedIndex] = leftArr[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copier les éléments restants du sous-tableau droit s'il y en a
        while (rightIndex < n2)
        {
            arr[mergedIndex] = rightArr[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }

    /*
    ## Commentaires
    Lorsque nous appelons la fonction MergeSort initiallement, nous passons les valeurs "low" = 0 et "high" = length - 1, où "length" est la taille totale de la liste.
    Cela signifie que nous voulons trier la liste entière, du premier élément au dernier élément.

    Lors de la récursion, nous divisons la liste en deux moitiés égales en calculant l'indice du milieu (middle = (low + high) / 2).
    Ensuite, nous appelons récursivement MergeSort pour trier la première moitié de la liste (de "low" à "middle") et la deuxième moitié de la liste (de "middle + 1" à "high").

    ## Cas d'utilisation
    - Lorsque vous devez trier une grande quantité de données, car Merge Sort a une complexité de temps stable de O(n log n).
    - Lorsque vous avez suffisamment de mémoire disponible pour stocker les sous-tableaux temporaires pendant le tri.
    - Lorsque la stabilité du tri est importante, car Merge Sort préserve l'ordre relatif des éléments égaux.

    ## Appel
    ```C#
    int[] numbers = { 5, 2, 9, 1, 3, 6 };
    Console.WriteLine("Liste avant le tri : " + string.Join(", ", numbers));

    MergeSort(numbers, 0, numbers.Count - 1);

    Console.WriteLine("Liste après le tri : " + string.Join(", ", numbers));
    ```
    Dans cet exemple, nous utilisons un tableau d'entiers non triés. L'appel à la fonction MergeSort est effectué en passant le tableau, l'indice de départ (0) et l'indice de fin (numbers.Length - 1) pour trier le tableau entier.

    Après l'exécution de la fonction MergeSort, le tableau sera trié dans l'ordre croissant. Nous imprimons le tableau avant et après le tri pour vérifier le résultat.

    ## Cas Croissant

    if (leftArr[leftIndex] <= rightArr[rightIndex])
    {
        arr[mergedIndex] = leftArr[leftIndex];
        leftIndex++;
    }
    else
    {
        arr[mergedIndex] = rightArr[rightIndex];
        rightIndex++;
    }

    ## Cas Décroissant

    if (leftArr[leftIndex] >= rightArr[rightIndex]) // Changement ici pour trier en ordre décroissant
    {
        arr[mergedIndex] = leftArr[leftIndex];
        leftIndex++;
    }
    else
    {
        arr[mergedIndex] = rightArr[rightIndex];
        rightIndex++;
    }

    */

    // Descending
    public static void MergeSortDescending(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int middle = (low + high) / 2;
            MergeSortDescending(arr, low, middle); // Trier la première moitié de la liste
            MergeSortDescending(arr, middle + 1, high); // Trier la deuxième moitié de la liste
            MergeDescending(arr, low, middle, high); // Fusionner les deux moitiés triées en ordre descendant
        }
    }

    private static void MergeDescending(int[] arr, int low, int middle, int high)
    {
        int n1 = middle - low + 1; // Taille de la première moitié
        int n2 = high - middle; // Taille de la deuxième moitié

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = arr[low + i];
        for (int j = 0; j < n2; j++)
            rightArr[j] = arr[middle + 1 + j];

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = low;

        while (leftIndex < n1 && rightIndex < n2)
        {
            if (leftArr[leftIndex] >= rightArr[rightIndex]) // Inverser la condition pour l'ordre descendant
            {
                arr[mergedIndex] = leftArr[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[mergedIndex] = rightArr[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        while (leftIndex < n1)
        {
            arr[mergedIndex] = leftArr[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < n2)
        {
            arr[mergedIndex] = rightArr[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }

}