var students = new List<Student>()
{
    new Student(1, "Jignesh", new DateTime(2022, 3, 15), 500),
    new Student(2, "Dharmik", new DateTime(2022, 3, 12), 550),
    new Student(3, "Priyal", new DateTime(2021, 3, 10), 299),
    new Student(4, "Rohit", new DateTime(2022, 4, 18), 535),
    new Student(4, "Tilak", new DateTime(2022, 4, 18), 300)
};

foreach (var item in students)
{
    Console.WriteLine($"Id :{ item.Id}  |  Name :  { item.Name} | Joing Date : {item.JoiningDate.ToShortDateString()} | Marks : {item.Marks}");
}

var topScorer = students.OrderByDescending(x => x.Marks).First();
Console.WriteLine($"Top Scorer in the class :  Id : {topScorer.Id} Name : {topScorer.Name}");

var topScorer = students.MaxBy(x => x.Marks);

Console.WriteLine($"Top Scorer in the class :  Id : {topScorer?.Id} Name : {topScorer?.Name} Who scrored {topScorer?.Marks} marks");

var poorPerfomer = students.OrderBy(x => x.Marks).First();

Console.WriteLine($"Lowest Score in the class :  Id : {topScorer?.Id} Name : {topScorer?.Name} Who scrored {topScorer?.Marks} marks");

var poorPerfomer = students.MinBy(x => x.Marks);

Console.WriteLine($"Lowest Score in the class :  Id : {poorPerfomer?.Id} Name : {poorPerfomer?.Name} Who scrored {poorPerfomer?.Marks} marks");

var students = new List<Student>()
{
    new Student(1, "Jignesh", new DateTime(2022, 3, 15), 500),
    new Student(2, "Dharmik", new DateTime(2022, 3, 12), 550),
    new Student(3, "Priyal", new DateTime(2021, 3, 10), 299),
    new Student(4, "Rohit", new DateTime(2022, 4, 18), 535),
    new Student(4, "Tilak", new DateTime(2022, 4, 18), 300),
    new Student(4, "Jaymin", new DateTime(2022, 4, 18), 550)
};