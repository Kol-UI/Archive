//  Shell Sort
// Work in the same way as a generalized version of the Insertion Sort algorithm
// The algorithm sorts elements at a specific interval first
// And reduces that interval gradually until it is equal to one
// Depends on the interval size /!\

// Shell Sort Principes:
// The algorithm DETERMINEs the size of the intervals going to be used
// DIVIDE the array into conceptual subarrays using the elements whose distance is determined by the interval
// SORT the conceptual subarrays in place
// SHORTEN the gap by N/2 (Shell’s sequence)
// REPEAT the steps above until the interval is equal to 1 and use insertion sort to complete the sorting process

static int[] ShellSort(int[] input)
{
    // Exemple of array {34, 31, 39, 9, 15, 19, 26, 44}
    int size = input.Length;
    // We compare and swap the elements lying at the interval of 4
    // For example, the element at index zero gets compared with the element at index three in the input 
    // Using Shell’s original sequence as the outer loop keeps subdividing the gap by two until it gets equal to one
    for (int interval = size / 2; interval > 0; interval /= 2)
    {
        // Iteration 1:
        // At the interval of 4, here are the sublists that we have:
        // [First of half + first of second half] until end
        // [0][4], [1][5], [2][6], [3][7]
        // {34, 15}, {31, 19}, {39, 26}, {9, 44}

        // Next we compare the elements in these sublists
        // And swap their positions in the original array accordingly:
        // [0.1] [1.1] [2.1] [3.0] [0.0] [1.0] [2.0] [3.1]
        // 15  ,  19  ,  26 ,  9  ,  34 , 31 ,  39 ,  44
        // First half = smallest values of each sub groups
        // Second half = biggest values of each sub groups

        // Iteration 2:
        // We set the interval to 2 i.e. N/4.
        // These are the conceptual subarrays that we are going to sort next:
        // [0] [2] [4] [6] and [1] [3] [5] [7]
        // {15, 26, 34, 39} and {19, 9, 31, 44}

        // Once more, we are going to compare these elements and update their positions on the original array, which becomes:
        // [0.0] [0.1] [0.1] [1.1] [0.2] [1.2] [1.3] [1.3]
        //  15 ,   9 ,  26 ,  19 ,  34 ,  31 ,  39 ,  44

        // Insertion Sort Part
        // For every gap interval, the function uses insertion sort to compare and swap array elements until the array is sorted. 
        for (int i = interval; i < size; i++)
        {
            // Finale Iteration:
            // The interval will be equal to 1 (N/8 = 1)
            // We are going to use Insertion Sort to complete the sorting process 
            // Assuming 15 is a sorted list of the first item, we are going to compare 15 with 9
            // Since 9 is less than 15, we swap their positions and the array becomes:
            // 9, 15, 26, 19, 34, 31, 39, 44
            // 15 is not greater than 26 while 19 is less than 26 so, we swap their positions, and the array becomes:
            // 9, 15, 19, 26, 34, 31, 39, 44
            // 26 is less than 34 but 31 is less than 34, so we swap their positions to complete the sorting process: 
            // 9, 15, 19, 26, 31, 34, 39, 44
            var currentKey = input[i];
            var k = i;
            while (k >= interval && input[k - interval] > currentKey)
            {
                input[k] = input[k - interval];
                k -= interval;
            }
            input[k] = currentKey;
        }
    }
    return input;
}

// The space complexity of the algorithm is O(n), with n being the size of the array
// On top of that, the algorithm takes O(1) as auxiliary space, which means, it does not require any extra space to run

// Best Case Time Complexity:
// The Shell Sort algorithm encounters its best-case time complexity scenario when it encounters an array that is already sorted
// The number of comparisons for every interval is equal to the size of the array
// Therefore, the algorithm has a best-case time complexity of O(n log n)

// Average Case Time Complexity:
// The shell sort algorithm has an average-case time complexity of O(n log n)
// Just as its best-case time complexity
// This scenario occurs when we use different intervals and it depends on the interval chosen by the programmer 

// Worst Case Time Complexity:
// We can simulate worst-case time complexity O(n log^2 n):
// When we put the smallest elements in odd positions & the largest elements in even positions.
// For example, when we try to sort an array such as 2, 11, 4, 12, 6, 13, 8, 14
// None of the passes (N/2, N/4, …, 2) rearrange the elements.
// The algorithm will swap the elements in the last pass when the gap is 1,
// Which would force the algorithm to perform n2 comparisons.

// Advantages:
// It is efficient when sorting medium size arrays
// Do not require any extra space to run unlike sorting algorithms such as merge sort
// Shell Sort performs better than Insertion Sort & Bubble Sort
// Shell Sort is more efficient than Insertion Sort if the length of input arrays is small

// Disadvantages:
// It can be less efficient than other sorting algorithms for large data sets such as merge sort and quicksort
// Additionally, the algorithm is not stable, meaning that it may not preserve the order of elements with equal keys just like quicksort

public static void ShellSort(int[] array)
{
    int n = array.Length;
    
    for (int interval = n / 2; interval > 0; interval /= 2)
    {
        for (int i = interval; i < n; i++)
        {
            int temp = array[i];
            int j = i;
            
            while (j >= interval && array[j - interval] > temp)
            {
                array[j] = array[j - interval];
                j -= interval;
            }
            
            array[j] = temp;
        }
    }
}

/*
    Fonctionnement :
    Le tri Shell, également appelé Shell Sort, est un algorithme de tri qui améliore l'efficacité de l'algorithme d'insertion.
    Il fonctionne en divisant le tableau en plusieurs sous-tableaux plus petits, puis en triant ces sous-tableaux à l'aide de l'algorithme d'insertion.
    À mesure que les sous-tableaux deviennent de plus en plus petits, l'algorithme se rapproche de la séquence triée finale.

    Explications :
    L'algorithme Shell Sort commence par diviser le tableau en plusieurs sous-tableaux en utilisant un intervalle (gap).
    Chaque sous-tableau est ensuite trié à l'aide de l'algorithme d'insertion.
    L'intervalle est réduit à chaque itération, ce qui permet de raffiner davantage le tri.
    L'idée est de d'abord trier les éléments éloignés les uns des autres.
    Ppuis de les rapprocher progressivement jusqu'à ce que le tableau soit finalement trié.

    Étapes :
    1. Choisissez une séquence d'intervalle (gap) pour diviser le tableau en sous-tableaux.
    2. Pour chaque intervalle, triez les sous-tableaux à l'aide de l'algorithme d'insertion.
    3. Réduisez progressivement l'intervalle jusqu'à ce que le tableau soit finalement trié.

    Compléxité et Utilisation :
    Le tri Shell est plus efficace que l'algorithme d'insertion pour de grands tableaux.
    Sa complexité temporelle dépend de la séquence d'intervalle choisie,
    mais elle est généralement meilleure que O(n^2) pour de nombreuses séquences.
    Cependant, il n'est pas aussi rapide que des algorithmes de tri plus avancés comme le tri fusion ou le tri rapide.

    Le tri Shell peut être utilisé lorsque vous souhaitez trier des tableaux de taille moyenne à grande.
    C'est un compromis entre la simplicité de l'insertion sort et l'efficacité des algorithmes de tri plus avancés.
    Vous pouvez expérimenter avec différentes séquences d'intervalle pour trouver la plus appropriée pour votre cas d'utilisation.
*/


// Descending
public static void ShellSortDescending(int[] array)
{
    int n = array.Length;

    for (int interval = n / 2; interval > 0; interval /= 2)
    {
        for (int i = interval; i < n; i++)
        {
            int temp = array[i];
            int j = i;

            while (j >= interval && array[j - interval] < temp) // Inverser la condition pour l'ordre décroissant
            {
                array[j] = array[j - interval];
                j -= interval;
            }

            array[j] = temp;
        }
    }
}