var numList = new List<int>()
{
    1, 4, 5, 7, 4, 10
};

var sumResults = SumOfNums(numList);

foreach (var sumResult in sumResults)
{
    Console.WriteLine(sumResult);
}
    
IEnumerable<int> SumOfNums(List<int> nums)
{
    var results = new List<int>();
    var sum = 0;
    foreach (var num in nums)
    {
        sum += num;
        results.Add(sum);
    }

    return results;
}

/*
Output : 
1
5
10
17
21
31
*/

var numList = new List<int>()
{
    1, 4, 5, 7, 4, 10
};

foreach (var result in SumOfNums(numList))
{
    Console.WriteLine(result);
}

IEnumerable<int> SumOfNums(List<int> nums)
{
    var sum = 0;
    foreach (var num in nums)
    { 
        sum += num;
        yield return sum;
    }
}

/*
Output : 
1
5
10
17
21
31
*/