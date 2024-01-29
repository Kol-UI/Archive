
//  Counting Sort
// Principe: Counting the number of occurrences of each distinct element in the list

// Iterating through the input, counting the number of times each item appears, and utilizing those counts to compute each item's index in the final,
// sorted array is how counting sort works.

// Positive Int only !
// Fast But use a lot of Memory (generate )

static int[] CountingSort(int[] input)
{
    var size = input.Length;
    // Exemple : {7, 1, 2, 8, 9, 9, 4, 1, 5, 5};
    // We start by finding the largest element in the array (9) by using GetMaxVal();
    var maxElement = GetMaxVal(input, size);
    // The counting sort algorithm initializes an array of size [getMax(array[ ])+1]
    // to store the occurrences of distinct elements.
    // We define an array of size maxElement + 1 and initialize all the values to zero.
    var occurrences = new int[maxElement + 1];

    // we start populating the occurrences array by storing the occurrences of each unique element in the array:
    for (int i = 0; i < maxElement + 1; i++)
    {
        occurrences[i] = 0;
    }
    for (int i = 0; i < size; i++)
    {
        occurrences[input[i]]++;
    }
    // The algorithm loops through the unsorted array 
    // While storing the number of occurrences of every distinct element in the occurrences array
    // Which it achieves by mapping the distinct values with their indexes in the occurrences array:
    // Value: 0, 2, 1, 0, 1, 2, 0, 1, 1, 2
    // Index: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9

    // We iterate through the array as we retrieve the occurrences of each distinct element as we populate the sorted array:
    // 1, 1, 2, 4, 5, 5, 7, 8, 9, 9
    for (int i = 0, j = 0; i <= maxElement; i++)
    {
        while (occurrences[i] > 0)
        {
            input[j] = i;
            j++;
            occurrences[i]--;
        }
    }

    return input;
}

// Return the largest integer in the array
static int GetMaxVal(int[] input, int size)
{
    // The GetMaxVal() method iterates through the array from the first element to the last one
    // While updating the value of maxVal
    var maxVal = input[0];
    for (int i = 1; i < size; i++)
    {
        if (input[i] > maxVal)
        {
            maxVal = input[i];
        }
    }
    return maxVal;
}

/*
    The Pseudocode of Counting Sort
    Iterate through the input array to find the highest value.
    Declare a new array with the value 0 and a size of max+1.
    Count each element in the array and increment its value in the auxiliary array generated at the corresponding index.
    Add current and previous frequency to the auxiliary array to find the cumulative sum.
    The cumulative value now represents the element's actual position in the sorted input array.
    Begin iterating through the auxiliary array from 0 to max.
    Put 0 at the corresponding index and reduce the count by 1, which will indicate the element's second position in the input array if it exists.
    Now put the array you got in the previous step into the actual input array.
*/


// Description
// Counting sort utilizes the knowledge of the smallest and the largest element in the array (structure).
// Using this information, it can create a helper array of frequencies of all discrete values in the main array
// and later recalculate it into the array of occurrences (for every value the array of occurrences contains an index of its last occurrence in a sorted array).

// With this information the actual sorting is simple.
// Counting sort iterates over the main array and fills the appropriate values, whose positions are known thanks to the array of occurrences.

// The counting sort algorithm requires an auxiliary array of size k (max element + 1)
// Therefore, the space complexity of the counting sort algorithm is O(k).

// Advantages:
// It is relatively simple to understand and implement
// The algorithm is very efficient for collections with a small range of values
// The algorithm is stable, meaning that items with equal values will retain their original order after being sorted unlike other sorting algorithms such as quicksort

// Disavantages:
// The algorithm is not well-suited for collections with a large range of values,
    // Because the algorithm’s efficiency decreases as the range of values increases. 
// Counting sort is not an in-place sorting algorithm since it requires additional space unlike algorithms such as Quicksort, Insertion sort, and Bubble sort.
// The algorithm can be slower than algorithms that use divide and conquer approaches such as Merge Sort and Quicksort for large arrays.
// If non-primitive (object) elements are sorted, another helper array is needed to store the sorted elements.
// The major disadvantage is that counting sort can be used only to sort discrete values (for example integers), because otherwise the array of frequencies cannot be constructed.


// Other Info:
// Because its running duration is proportional to the number of items and the difference between the maximum and minimum key values,
// it is only suited for direct usage when the number of items is not much more than the variation in keys.

// It's frequently used as a subroutine in radix sort, a more efficient sorting method for larger keys.


public static int[] CountingSort(int[] array)
{
    var size = array.Length;
    var maxElement = GetMaxVal(array, size);
    var occurrences = new int[maxElement + 1];

    for (int i = 0; i < maxElement + 1; i++)
    {
        occurrences[i] = 0;
    }

    for (int i = 0; i < size; i++)
    {
        occurrences[array[i]]++;
    }

    for (int i = 0, j = 0; i <= maxElement; i++)
    {
        while (occurrences[i] > 0)
        {
            array[j] = i;
            j++;
            occurrences[i]--;
        }
    }

    return array;
}

private static int GetMaxVal(int[] array, int size)
{
    var maxVal = array[0];

    for (int i = 1; i < size; i++)
    {
        if (array[i] > maxVal)
        {
            maxVal = array[i];
        }
    }
        
    return maxVal;
}

/*
    Fonctionnement du Counting Sort :

    Le Counting Sort est un algorithme de tri linéaire qui fonctionne en comptant le nombre d'occurrences de chaque élément dans le tableau à trier.
    Il utilise ces comptages pour déterminer la position de chaque élément dans le tableau trié.

    1. Initialisation du tableau d'occurrences :
    Un tableau d'occurrences est créé pour stocker le nombre d'éléments de chaque valeur présente dans le tableau d'entrée.

    2. Comptage des occurrences :
    Parcours du tableau d'entrée pour compter le nombre d'occurrences de chaque élément.
    Le tableau d'occurrences est mis à jour en conséquence.

    3. Calcul des positions :
    En utilisant le tableau d'occurrences, on calcule la position finale de chaque élément dans le tableau trié.

    4. Construction du tableau trié :
    Les éléments sont placés dans le tableau trié en fonction de leurs occurrences.

    Complexité

    La complexité temporelle du Counting Sort est linéaire, soit O(n), où n est la taille du tableau d'entrée.
    Cependant, il convient de noter que cela dépend du domaine des valeurs d'éléments.
    Si le domaine est significativement plus petit que la taille du tableau, l'algorithme peut être très efficace.

    Utilisation

    Le Counting Sort est particulièrement efficace lorsque les éléments du tableau sont dans un domaine limité et relativement petits en nombre.
    Il est moins efficace lorsque le domaine des valeurs est large, car cela entraîne une augmentation de l'espace mémoire requis pour le tableau d'occurrences.

    Cas décroissant 

    Le Counting Sort tel qu'implémenté triera également un tableau dans l'ordre décroissant.
    Cela est dû au fait que, lors de la construction du tableau trié, les éléments sont placés en fonction de leurs occurrences, de gauche à droite dans le tableau résultant.
    Si un élément a une occurrence plus élevée, il sera placé vers la fin du tableau trié.
    Ainsi, l'algorithme tel qu'implémenté fonctionne pour les tableaux dans l'ordre décroissant ou croissant.


    Utilisation 

    Quand utiliser le Counting Sort :
    1. Petit domaine des valeurs :
    Le Counting Sort est particulièrement efficace lorsque le domaine des valeurs dans le tableau est relativement petit par rapport à la taille du tableau.
    Si les valeurs sont des entiers dans une plage limitée, le Counting Sort peut être très performant.

    2. Éléments répétés :
    L'algorithme fonctionne bien lorsque le tableau contient des éléments répétés, car il compte simplement le nombre d'occurrences de chaque élément.

    3. Stabilité :
    Le Counting Sort est un algorithme stable, ce qui signifie qu'il préserve l'ordre relatif des éléments égaux.
    Cela peut être important dans certaines applications.

    4. Complexité linéaire :
    Lorsque la complexité en espace n'est pas un problème (notamment lorsque le domaine des valeurs est relativement petit),
    le Counting Sort peut être un choix rapide en termes de temps, avec une complexité temporelle linéaire.

    Quand ne pas utiliser le Counting Sort :

    1. Grand domaine des valeurs :
    Si le domaine des valeurs est très large par rapport à la taille du tableau,
    l'espace mémoire requis pour le tableau d'occurrences peut devenir prohibitif.

    2. Valeurs non entières :
    Le Counting Sort est principalement conçu pour trier des tableaux d'entiers.
    Si les valeurs du tableau sont des nombres à virgule flottante ou d'autres types de données, d'autres algorithmes de tri peuvent être plus appropriés.

    3. Non adapté aux structures complexes :
    Lorsque les éléments du tableau sont des structures complexes et que l'on souhaite trier en fonction de certaines propriétés de ces structures, le Counting Sort n'est pas le choix optimal.
    Des algorithmes de tri plus généraux comme le tri rapide (QuickSort) ou le tri fusion (MergeSort) peuvent être plus adaptés dans de tels cas.

    En résumé, le Counting Sort est un choix efficace dans des contextes spécifiques, principalement lorsque le domaine des valeurs est limité.
    Pour des situations plus générales, d'autres algorithmes de tri peuvent être préférés en fonction des caractéristiques spécifiques du problème à résoudre.

*/