// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

LogikBuilding.LogikBuildingFacade facade = new LogikBuilding.LogikBuildingFacade();

string result = facade.OddEven(5);
Console.WriteLine($"The number 5 is {result}.");
