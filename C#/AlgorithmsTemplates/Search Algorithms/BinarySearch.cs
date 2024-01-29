using System;

public static class BinarySearch 
{
	/*
		Recherche binaire (Binary Search) : Un algorithme efficace pour rechercher un élément dans un tableau trié en divisant répétitivement le tableau par deux et en comparant l'élément cible avec l'élément au milieu.
		- Tableau trié uniquement
		- Sert à trouver un élément spécifique, le premier de la liste

		## Fonctionnement
		Diviser répétitivement le tableau en deux moitiés et de comparer l'élément cible avec l'élément du milieu.

		En fonction du résultat de la comparaison, la recherche continue dans la moitié gauche ou la moitié droite du tableau, en répétant le processus jusqu'à ce que l'élément cible soit trouvé ou que la recherche ait épuisé toutes les possibilités.

		## Etapes
		Etapes générales de l'algorithme de recherche binaire :
		1. Définir les indices de début et de fin du tableau (généralement 0 et la longueur du tableau - 1).
		2. Tant que l'indice de début est inférieur ou égal à l'indice de fin, continuer la recherche.
		3. Calculer l'indice du milieu en faisant la moyenne de l'indice de début et de l'indice de fin.
		4. Comparer l'élément du milieu avec l'élément cible.
			- Si l'élément du milieu est égal à l'élément cible, la recherche est terminée et l'élément cible est trouvé.
			- Si l'élément du milieu est plus petit que l'élément cible, réduire la recherche à la moitié supérieure du tableau (déplacer l'indice de début au-dessus de l'indice du milieu + 1).
			- Si l'élément du milieu est plus grand que l'élément cible, réduire la recherche à la moitié inférieure du tableau (déplacer l'indice de fin en dessous de l'indice du milieu - 1).
		5. Répéter les étapes 3-4 jusqu'à ce que l'élément cible soit trouvé ou que la recherche ait épuisé toutes les possibilités (indice de début > indice de fin).

		## Complexité
		La recherche binaire a une complexité de temps logarithmique O(log n), ce qui signifie que le nombre d'opérations de comparaison nécessaires augmente de manière logarithmique avec la taille du tableau.
		Cela en fait un algorithme très efficace pour la recherche dans de grandes collections de données triées.

		## Implémentation (Itérative)
	*/
	public static int BinarySearch(int[] array, int target)
	{
		int left = 0;
		int right = array.Length - 1;

		while (left <= right)
		{
			int mid = left + (right - left) / 2;

			if (array[mid] == target)
				return mid; // La valeur cible a été trouvée à l'indice mid

			if (array[mid] < target)
				left = mid + 1; // La valeur cible est plus grande, on recherche dans la moitié droite
			else
				right = mid - 1; // La valeur cible est plus petite, on recherche dans la moitié gauche
		}

		return -1; // Élément non trouvé
	}
	/*
		## Etapes Commentées
	*/
	public static int BinarySearch(int[] array, int target)
	{
		// 1) Définir les indices de début et de fin du tableau (généralement 0 et la longueur du tableau - 1).
		int left = 0;
		int right = array.Length - 1;

		// 2) Tant que l'indice de début est inférieur ou égal à l'indice de fin, continuer la recherche.
		while (left <= right)
		{
			// 3) Calculer l'indice du milieu en faisant la moyenne de l'indice de début et de l'indice de fin.
			int mid = left + (right - left) / 2;

			// 4) Comparer l'élément du milieu avec l'élément cible.
			// 4.1) Si l'élément du milieu est égal à l'élément cible, la recherche est terminée et l'élément cible est trouvé.
			if (array[mid] == target)
				return mid; // La valeur cible a été trouvée à l'indice mid

			// 4.2) Si l'élément du milieu est plus petit que l'élément cible, réduire la recherche à la moitié supérieure du tableau (déplacer l'indice de début au-dessus de l'indice du milieu + 1).
			// 4.3) Si l'élément du milieu est plus grand que l'élément cible, réduire la recherche à la moitié inférieure du tableau (déplacer l'indice de fin en dessous de l'indice du milieu - 1).
			if (array[mid] < target)
				left = mid + 1; // La valeur cible est plus grande, on recherche dans la moitié droite
			else
				right = mid - 1; // La valeur cible est plus petite, on recherche dans la moitié gauche

			// 5) Répéter les étapes 3-4 jusqu'à ce que l'élément cible soit trouvé ou que la recherche ait épuisé toutes les possibilités (indice de début > indice de fin).
		}

		return -1; // Élément non trouvé
	}
	/*
		Dans cet exemple, la méthode `BinarySearch` prend en paramètres un tableau d'entiers trié (`array`) et la valeur cible à rechercher (`target`).
		Elle retourne l'indice de l'élément cible dans le tableau, ou -1 si l'élément n'est pas trouvé.

		L'algorithme utilise une boucle while pour effectuer la recherche binaire.
		À chaque itération, il calcule l'indice du milieu (`mid`) en utilisant la formule `(left + right) / 2`,
		puis compare la valeur de `array[mid]` avec la valeur cible.
		En fonction de cette comparaison, la recherche se poursuit soit dans la moitié gauche du tableau (en mettant à jour la variable `right`),
		soit dans la moitié droite du tableau (en mettant à jour la variable `left`).

		La boucle continue jusqu'à ce que l'indice de début (`left`) dépasse l'indice de fin (`right`),
		ce qui indique que l'élément cible n'est pas présent dans le tableau.

		Cet exemple suppose que le tableau est trié par ordre croissant.
		Si le tableau est trié par ordre décroissant, il faut ajuster les conditions de comparaison en conséquence.

		## L'appel
		Cet exemple effectue une recherche binaire dans le tableau `{ 1, 2, 3, 4, 5, 7, 9, 10 }` pour trouver l'élément 4.
		```
		int[] array = { 1, 2, 3, 4, 5, 7, 9, 10 };
		int target = 4;
		int result = 0;

		int index = BinarySearch(array, target);
		if (index != -1)
		{
			Console.WriteLine($"L'élément {target} a été trouvé à l'indice {index}.");
			result = array[index];
		}
		else
			Console.WriteLine($"L'élément {target} n'a pas été trouvé dans le tableau.");
		```
		
		La méthode `BinarySearch` retourne l'indice 3, car l'élément 4 se trouve à cet indice dans le tableau.

		## Cas Décroissant
		La seule différence par rapport à la recherche binaire standard est l'inversion des comparaisons dans les conditions.
		Lorsque `array[mid]` est inférieur à la valeur cible (`target`), la variable `right` est mise à jour pour restreindre la recherche à la moitié gauche du tableau.
		Dans le cas où `array[mid]` est supérieur à la valeur cible, la variable `left` est mise à jour pour restreindre la recherche à la moitié droite du tableau
	*/
	public static int BinarySearchDescending(int[] array, int target)
	{
		int left = 0;
		int right = array.Length - 1;

		while (left <= right)
		{
			int mid = left + (right - left) / 2;

			if (array[mid] == target)
				return mid;

			if (array[mid] < target)
				right = mid - 1; // Changement !
			else
				left = mid + 1; // Changement !
		}

		return -1; // Élément non trouvé
	}
	/*
		- Dans l'implémentation pour l'ordre croissant, lorsque `array[mid]` est inférieur à la valeur cible (`target`), la mise à jour se fait avec `left = mid + 1;`.
		- Dans l'implémentation pour l'ordre décroissant, lorsque `array[mid]` est inférieur à la valeur cible (`target`), la mise à jour se fait avec `right = mid - 1;`.
		Ces différences s'expliquent par le fait que dans un tableau trié par ordre croissant, les éléments plus petits sont situés à gauche de l'élément central,
		tandis que dans un tableau trié par ordre décroissant, les éléments plus petits sont situés à droite de l'élément central.

		## Implémentation (Recursive)
	*/
	public static int BinarySearch(int[] array, int target)
	{
		return BinarySearchRecursive(array, target, 0, array.Length - 1);
	}

	private static int BinarySearchRecursive(int[] array, int target, int left, int right)
	{
		if (left > right)
		{
			return -1; // La valeur cible n'a pas été trouvée dans le tableau
		}

		int mid = left + (right - left) / 2;

		if (array[mid] == target)
		{
			return mid; // La valeur cible a été trouvée à l'indice mid
		}
		else if (array[mid] < target)
		{
			return BinarySearchRecursive(array, target, mid + 1, right); // Recherche dans la moitié droite
		}
		else
		{
			return BinarySearchRecursive(array, target, left, mid - 1); // Recherche dans la moitié gauche
		}
	}
	/*
		## Cas Décroissant (Recursive)
	*/
	public static int BinarySearchDescending(int[] array, int target)
	{
		return BinarySearchDescendingRecursive(array, target, 0, array.Length - 1);
	}

	private static int BinarySearchDescendingRecursive(int[] array, int target, int left, int right)
	{
		if (left > right)
		{
			return -1; // La valeur cible n'a pas été trouvée dans le tableau
		}

		int mid = left + (right - left) / 2;

		if (array[mid] == target)
		{
			return mid; // La valeur cible a été trouvée à l'indice mid
		}
		else if (array[mid] < target)
		{
			return BinarySearchDescendingRecursive(array, target, left, mid - 1); // Recherche dans la moitié gauche
		}
		else
		{
			return BinarySearchDescendingRecursive(array, target, mid + 1, right); // Recherche dans la moitié droite
		}
	}


	// Iterative Version is easy to implement
	// While Recursive Version more efficient

	// Binary search is a search algorithm that finds the position of a key or target value within a array.
	// Binary search compares the target value to the middle element of the array;
	// if they are unequal, the half in which the target cannot lie is eliminated and the search continues on the remaining half until it is successful.

	// Iterative Binary Search :
	// In the case of Iterative algorithms, a certain set of statements are repeated a certain number of time.
	// An Iterative algorithm will use looping statements such as for loop, while loop or do-while loop to repeat the same steps number of time.

	// Revursive Binary Search :
	// A function calls itself again and again till the base condition(stopping condition) is satisfied.
	

	// /!\ Binary Search is used in order to find 1 Specific Element, the first one that correspond, not all occurences /!\
	// If Array not ordonned => Linear Search.

		
	// Using two index start and end
	// Initialy low = 0 and high = n - 1 (as initialy whole array is search space).
	// At each step, we find mid value in the search space and compare it with target value. There are three cases possible:
	// Case 1: If target is equal to middle, then return mid.
	// Case 2: If target is less than middle i.e target<A[mid], we discard all the elements in the right search space including mid element.
	// 			Now our new high would be mid-1 while 'low' remains as it is.
	// Case 3: If the target element is greater than middle i.e target>A[mid],we discard all the elements in the left search space including mid element.
	//			Now our new low would be mid+1 while 'high' remains as it is.

	// Assumes 'arr' is in sorted order.
	
	// Iterative implementation of Binary Search
	public static int BinarySearchIterative(int[] arr, int num) 
    {
		int mid, low, high;

		low = 0;
		high = arr.Length - 1;
		
		while(low <= high) 
        {
			mid = (low + high) / 2;
			
			if(num < arr[mid]) 
            {
				high = mid - 1;
			}
			else if(num > arr[mid]) 
            {
				low = mid + 1;
			}
			else  
            {
				return mid;
			}
		}
		return -1;
	}
	
	// Recursive implementation of Binary Search
	public static int BinarySearchRecursive(int[] arr, int num) 
    {
		return BinarySearchRecursiveHelper(arr, num, 0, arr.Length  - 1);
	}
	// Helper method for the recursive approach.
	private static int BinarySearchRecursiveHelper(int[] arr, int num, int low, int high) 
    {
		int mid = (low + high) / 2;
		
		if(low >= high) return -1;

        if (num < arr[mid])
        {
            return BinarySearchRecursiveHelper(arr, num, low, mid - 1);
        }
        else if (num > arr[mid])
        {
            return BinarySearchRecursiveHelper(arr, num, mid + 1, high);
        }
        else
        {
            return mid;
        }
	}
}
