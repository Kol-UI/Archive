
//  BubbleSort
// This is essentially worse case scenario for sorting data as it takes many “passes” of single swaps for things to actually sort

static void BubbleSort(int[] input)
{
    var itemMoved = false;
    do
    {
        itemMoved = false;
        // Stating at Index 0
        for (int i = 0; i < input.Count() - 1; i++)
        {
            // We take an item & the item next in the array
            // We compare them
                // If they are in the right order, then we do nothing
                // If they are in the wrong order
                    // Ex : The item lower in the array is actually a higher value than the next element
            if (input[i] > input[i + 1])
            {
                // Then we swap these items
                var lowerValue = input[i + 1];
                input[i + 1] = input[i];
                input[i] = lowerValue;
                itemMoved = true;
            }
            // Then we continue through each item in the array doing the same thing
            // Ex: Swapping with the next element if it’s higher
        }
    } while (itemMoved);
}

// Now since we are only comparing each item with it’s neighbour,
// each item may only move a single place when it actually needs to move several places.
// So how does Bubblesort solve this?
// By running the entire process all over again.
// Notice how we have the variable called “itemMoved”.
// We simply set this to true if we did swap an item and start the scan all over again.

// Because we are moving things one at a time,
// not directly to the right position and having to multiple passes to get things right, 
// BubbleSort is seen as extremely inefficient.


/*
Le fonctionnement du Bubble Sort (Tri à bulles) peut être expliqué en quelques étapes simples :

    1. Parcourez la liste d'éléments à trier, en comparant les éléments adjacents deux à deux, en commençant par le premier et le deuxième.

    2. Si l'élément actuel est plus grand (ou plus petit, selon le sens de tri) que l'élément suivant, échangez-les de place. Cela place l'élément plus grand vers la fin de la liste.

    3. Répétez ces comparaisons et échanges pour chaque paire d'éléments dans la liste, en continuant de la première à la dernière position. Cela forme "des bulles" d'éléments plus grands qui montent vers la fin de la liste.

    4. Continuez ce processus pour chaque élément de la liste jusqu'à ce que plus aucun échange ne soit nécessaire lors d'un passage complet.

    5. À la fin, la liste est triée, les éléments les plus petits étant "remontés" vers le début et les éléments les plus grands étant "poussés" vers la fin.

    Le tri à bulles est un algorithme simple mais inefficace pour trier de grandes quantités de données, car il effectue de nombreux échanges d'éléments. Il est principalement utilisé à des fins éducatives et pour illustrer les concepts de base des algorithmes de tri.
*/

// Ascending
public static void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j + 1] < array[j])
            {
                int tempo = array[j + 1];
                array[j + 1] = array[j];
                array[j] = tempo;
            }
        }
    }
}

// Descending
public static void BubbleSortDescending(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j + 1] > array[j]) // Inverse la condition pour l'ordre descendant
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
}