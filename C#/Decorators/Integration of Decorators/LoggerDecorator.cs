public class LoggerDecorator : IDataServiceDecorator
{
    private readonly IDataService _dataService;

    public LoggerDecorator(IDataService dataService)
    {
        _dataService = dataService;
    }

    public void GetData()
    {
        Console.WriteLine("Logging before GetData() method call...");
        _dataService.GetData();
        Console.WriteLine("Logging after GetData() method call...");
    }
}