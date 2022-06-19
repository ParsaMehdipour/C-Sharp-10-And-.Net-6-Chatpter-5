using Funtionalities;
using static System.Console;

Person bob = new()
{
    Name = "Bob",
    DateOfBirth = DateTime.Today.AddYears(-29),
};

Person alice = new()
{
    Name = "Alice",
    DateOfBirth = DateTime.Today.AddYears(-24),
};

//Person.Procreate(bob, alice, "janice");

bob.ProcreateWith(alice, "janice").WriteToConsole();

Person SecondBaby = Person.Procreate(bob, alice, "Mark");

Person ThirdBaby = bob * alice;

//bob.WriteToConsole();
//bob.Children.First().WriteToConsole();

//alice.WriteToConsole();
//alice.Children.First().WriteToConsole();

ReadLine();