services.AddScoped<IDataService, DataService>();
services.AddScoped<IDataServiceDecorator>(provider =>
    new LoggerDecorator(provider.GetService<IDataService>()));