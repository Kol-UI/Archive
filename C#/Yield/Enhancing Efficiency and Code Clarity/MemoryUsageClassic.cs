var arr = new int[1000];

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
var result = SumOfNums(arr.ToList());
stopwatch.Stop();
Console.WriteLine("Time elapsed using classic approach: " + stopwatch.ElapsedMilliseconds + "ms");

long memoryBefore = GC.GetTotalMemory(true);
result = SumOfNums(arr.ToList());
long memoryAfter = GC.GetTotalMemory(true);
Console.WriteLine("Memory used using classic approach: " + (memoryAfter - memoryBefore) + "bytes");

/*
Time elapsed using classic approach: 0ms
Memory used using classic approach: 8508bytes
*/


var arr = new int[1000];

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
var result = SumOfNums(arr.ToList());
stopwatch.Stop();
Console.WriteLine("Time elapsed using yield approach: " + stopwatch.ElapsedMilliseconds + "ms");

long memoryBefore = GC.GetTotalMemory(true);
result = SumOfNums(arr.ToList());
long memoryAfter = GC.GetTotalMemory(true);
Console.WriteLine("Memory used using yield approach: " + (memoryAfter - memoryBefore) + "bytes");

/*
Time elapsed using yield approach: 0ms
Memory used using yield approach: 4112bytes
*/