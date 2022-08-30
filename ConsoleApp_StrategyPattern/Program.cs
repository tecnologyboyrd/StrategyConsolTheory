// See https://aka.ms/new-console-template for more information
using ConsoleApp_StrategyPattern;

Console.WriteLine("Testing Strategy Architecture");


var Cnx = new Context(new Dog());
Cnx.WhoAmI();

Cnx.Strategy = new Cat();

Cnx.WhoAmI();


