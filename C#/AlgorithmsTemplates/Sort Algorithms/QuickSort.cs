
/*
    Tri récursif basé sur la stratégie de "diviser pour régner" qui choisit un pivot, partitionne la liste autour du pivot,
    puis trie récursivement les sous-listes résultantes.
*/


public class QuickSortClass
{
    public static void Sort(int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }

    private static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right); // Partitionner le tableau
            QuickSort(array, left, pivotIndex - 1); // Trier le sous-tableau de gauche du pivot
            QuickSort(array, pivotIndex + 1, right); // Trier le sous-tableau de droite du pivot
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right]; // Choix du pivot (dans cet exemple, dernier élément du tableau)
        int i = left - 1; // Index du dernier élément plus petit que le pivot

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j); // Échanger les éléments pour les mettre dans la bonne partition
            }
        }

        Swap(array, i + 1, right); // Placer le pivot à sa position finale
        return i + 1; // Retourner l'index du pivot
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

/*
    On utilise la méthode `Partition` pour partitionner le tableau en deux sous-tableaux autour d'un pivot.
    Ensuite, on appelle récursivement la méthode `QuickSort` pour trier les sous-tableaux de gauche et de droite du pivot.
    La méthode `Partition` sélectionne le pivot (dans cet exemple, il s'agit du dernier élément du tableau) et partitionne le tableau en déplaçant les éléments plus petits que le pivot vers la gauche et les éléments plus grands vers la droite. Elle retourne l'index du pivot après la partition.
    La méthode `Swap` est une fonction utilitaire pour échanger deux éléments dans le tableau.
*/


// Descending
public static void QuickSortDescending(int[] array)
{
    QuickSortDescending(array, 0, array.Length - 1);
}

private static void QuickSortDescending(int[] array, int left, int right)
{
    if (left < right)
    {
        int pivotIndex = PartitionDescending(array, left, right); // Partitionner le tableau en ordre décroissant
        QuickSortDescending(array, left, pivotIndex - 1); // Trier le sous-tableau de gauche du pivot
        QuickSortDescending(array, pivotIndex + 1, right); // Trier le sous-tableau de droite du pivot
    }
}

private static int PartitionDescending(int[] array, int left, int right)
{
    int pivot = array[right]; // Choix du pivot (dans cet exemple, dernier élément du tableau)
    int i = left - 1; // Index du dernier élément plus grand que le pivot

    for (int j = left; j < right; j++)
    {
        if (array[j] >= pivot) // Inverser la condition pour l'ordre décroissant
        {
            i++;
            Swap(array, i, j); // Échanger les éléments pour les mettre dans la bonne partition
        }
    }

    Swap(array, i + 1, right); // Placer le pivot à sa position finale
    return i + 1; // Retourner l'index du pivot
}

private static void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}