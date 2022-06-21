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

// non-generic lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha"); //Key Is An Integer
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: "harry", value: "Delta"); //Key Is A String

int key = 2; // lookup the value that has 2 as its key
WriteLine(format: "Key {0} has value: {1}",
arg0: key,
arg1: lookupObject[key]);

// lookup the value that has harry as its key
WriteLine(format: "Key {0} has value: {1}",
arg0: "harry",
arg1: lookupObject["harry"]);


// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
arg0: key,
arg1: lookupIntString[key]);


// calling implicit and explicit implementations of Lose
Person p = new();
p.Lose(); // calls implicit implementation of losing a key
((IGamePlayer)p).Lose(); // calls explicit implementation of losing a game
IGamePlayer player = p as IGamePlayer;
player.Lose(); // calls explicit implementation of losing a game

ReadLine();