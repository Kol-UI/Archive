
//  Selection Sort
// Selection Sort is actually very very similar to Insertion Sort

/*
    The goal of the selection sort algorithm is to find the minimum value of an array by iterating through each element.
    For each iteration, the algorithm compares the current minimum value of the array with the current element.
    If the current value is smaller than the minimum value, a swap process occurs.
    This process continues until the array is completely sorted.
*/

static void SelectionSort(int[] input)
{
    // What we are essentially doing is scanning the index from start to finish
    for (var i = 0; i < input.Length; i++)
    {
        // For each index,
        // we scan the rest of the array for an item that is lower (Infact, the lowest) compared to the current item
        var min = i;
        for (var j = i + 1; j < input.Length; j++)
        {
            // If we find one,
            if(input[min] > input[j])
            {
                // We swap it with the current item
                min = j;
            }
        }
        // The fact that the current item goes into a position later in the array isn’t too important,
        // as eventually, all elements will be checked

        // We are scanning one by one,
        // And then continuing with the next highest etc.
        if (min != i)
        {
            // Finding the lowest item in the list,
            // Putting it into an array,
            var lowerValue = input[min];
            input[min] = input[i];
            input[i] = lowerValue;
        }
    }
}

/*
    Example :

    int[] array = { 40, 10, 20, 30, 50 };
    First, we find the minimum value from elements 0 to 4 (indexes) and place it at position 0.
    The minimum value is 10.
    Since 40 is currently on position 0 we are going to swap it with 10:
    [10], [40], 20, 30, 50

    Then, we check the elements 1 through 4 and place the smallest value at position 1.
    In this case, 20 is the minimum and we swap it with 40:
    10, [20], [40], 30, 50

    Next, we check positions 2 through 4 and set the minimum value (30) to position 2:
    10, 20, [30], [40], 50
*/

// Here's a full implementation with a returned array
public int[] SortArray(int[] NumArray)
{
    var arrayLength = NumArray.Length;

    for (int i = 0; i < arrayLength - 1; i++)
    {
        var smallestVal = i;

        for (int j = i + 1; j < arrayLength; j++)
        {
            if (NumArray[j] < NumArray[smallestVal])
            {
                smallestVal = j;
            }
        }

        var tempVar = NumArray[smallestVal];
        NumArray[smallestVal] = NumArray[i];
        NumArray[i] = tempVar;
    }

    return NumArray;
}

/*
    We can see that the algorithm uses two nested loops during the sorting process.
    We define two variables (tempVar and smallestVal) that hold values during the sorting process.
    As the outer loop iterates, smallestVal holds the current position of the array while the inner loop compares the current minimum value to the rest of the elements.

    If the value of the array element is smaller than the current minimum value, swapping occurs.
    This process stops when the outer loop hits its arrayLength limit.  
*/

// Although selection sort performs slightly better when dealing with sorted arrays,
// it performs poorly when compared to other sorting algorithms such as merge sort.


/*
## Fonctionnement
Il fonctionne en sélectionnant à chaque itération l'élément minimum dans la portion non triée du tableau et en le plaçant à la fin de la portion triée jusqu'à ce que tout le tableau soit trié.

## Explications
- La fonction `SelectionSort` prend un tableau en entrée, effectue le tri par sélection, et retourne le tableau trié.
- L'algorithme commence par parcourir le tableau à partir de l'indice 0. À chaque itération, il trouve l'indice du minimum dans la portion non triée du tableau.
- Ensuite, il échange l'élément minimum avec l'élément actuel, plaçant ainsi l'élément minimum à la fin de la portion triée.
- Les itérations se poursuivent jusqu'à ce que tout le tableau soit trié.
*/

// Implémentation
public static int[] SelectionSort(int[] arr)
{
	int length = arr.Length;
	for (int i = 0; i < length - 1; i++)
	{
		// Trouver l'indice du minimum dans la portion non triée
		int minIndex = i;
		for (int j = i + 1; j < length; j++)
		{
			if (arr[j] < arr[minIndex])
			{
				minIndex = j;
			}
		}

		// Échanger l'élément minimum avec l'élément actuel
		int temp = arr[i];
		arr[i] = arr[minIndex];
		arr[minIndex] = temp;
	}
	return arr;
}


/*
## L'appel
static void Main()
{
	int[] arr = { 64, 25, 12, 22, 11 };
	Console.WriteLine("Tableau avant le tri :");
	PrintArray(arr);

	int[] sortedArr = SelectionSort(arr);

	Console.WriteLine("Tableau après le tri :");
	PrintArray(sortedArr);
}

static void PrintArray(int[] arr)
{
	foreach (int num in arr)
	{
		Console.Write(num + " ");
	}
	Console.WriteLine();
}
*/



// Ordre Décroissant
public static int[] SelectionSortDescending(int[] arr)
{
	int length = arr.Length;
	for (int i = 0; i < length - 1; i++)
	{
		// Trouver l'indice de l'élément maximum dans la portion non triée
		int maxIndex = i;
		for (int j = i + 1; j < length; j++)
		{
			if (arr[j] > arr[maxIndex])
			{
				maxIndex = j;
			}
		}

		// Échanger l'élément maximum avec l'élément actuel
		int temp = arr[i];
		arr[i] = arr[maxIndex];
		arr[maxIndex] = temp;
	}
	return arr;
}

/*
    Dans cette version modifiée de l'algorithme,
    la recherche de l'élément maximum se fait en vérifiant si l'élément actuel est plus grand que l'élément maximum actuel
    (au lieu de vérifier s'il est plus petit, comme dans le tri croissant)
    En conséquence, le tri est effectué dans l'ordre décroissant.
*/

/*
## Utilisation
    Cas d'utilisation :

    1. Petites listes non triées : Le tri par sélection peut être efficace pour trier de petites listes qui ne sont pas déjà triées. L'algorithme a une complexité en temps de O(n^2), ce qui le rend rapide pour de petites quantités de données.

    2. Stable tri non requis : Si la stabilité du tri (c'est-à-dire la préservation de l'ordre relatif des éléments égaux) n'est pas une exigence, le tri par sélection peut être une option simple.

    3. Complexité mémoire : Le tri par sélection est un tri en place, ce qui signifie qu'il ne nécessite pas de mémoire supplémentaire pour trier la liste. Cela peut être avantageux lorsque la mémoire est limitée.

    
    Cas où ne pas utiliser le tri par sélection et où d'autres algorithmes peuvent être préférables :

    1. Grandes listes : Le tri par sélection a une complexité en temps de O(n^2), ce qui le rend inefficace pour trier de grandes listes. Des algorithmes de tri plus rapides comme Quick Sort, Merge Sort, ou Tim Sort sont généralement préférés pour des listes de grande taille.

    2. Stabilité requise : Si vous avez besoin de conserver l'ordre relatif des éléments égaux, le tri par sélection n'est pas stable. Vous devriez plutôt utiliser des algorithmes stables tels que Merge Sort ou Insertion Sort.

    3. Listes partiellement triées : Le tri par sélection n'est pas efficace pour trier des listes partiellement triées ou presque triées. Des algorithmes comme Insertion Sort ou Bubble Sort peuvent être plus rapides dans de telles situations.

    4. Tri descendant : Pour un tri décroissant, le tri par sélection nécessite des modifications pour inverser la logique de comparaison. D'autres algorithmes de tri, tels que le tri rapide (Quick Sort) ou le tri fusion (Merge Sort), sont plus flexibles pour trier dans n'importe quel ordre.

    Le tri par sélection est un algorithme simple mais inefficace pour trier de grandes listes ou lorsque la stabilité est requise.
    Pour de grandes quantités de données ou des besoins spécifiques, il existe d'autres algorithmes de tri plus efficaces et flexibles. 
*/