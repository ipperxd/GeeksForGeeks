// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

LogikBuilding.BasicLogicFacade facade = new LogikBuilding.BasicLogicFacade();

string OddOrEvenResult = facade.OddEven(5);
Console.WriteLine($"The number 5 is {OddOrEvenResult}.");

List<string> MultiplicationResult = facade.MutiplicationTable(18);

for(int i = 0; i < MultiplicationResult.Count; i++)
    Console.WriteLine(MultiplicationResult[i]);
