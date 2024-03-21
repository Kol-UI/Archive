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
    for (int i = 0; i < nums.Count; i++)
    {
        if (i == 2)
        {
            yield break;
        }
        sum += nums[i];
        yield return sum;
    }
}

/*
Output : 
1
5
*/