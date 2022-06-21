using static System.Console;

namespace Funtionalities;

public interface IGamePlayer
{
    void Lose();
}

public interface IKeyHolder
{
    void Lose();
}

public class Person : IGamePlayer, IKeyHolder
{
    // fields
    public string? Name; // ? allows null
    public DateTime DateOfBirth;
    public List<Person> Children = new(); // C# 9 or later

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    // static method to "multiply"
    public static Person Procreate(Person p1, Person p2, string name)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name} who's name is {name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2, "Baby");
    }

    // instance method to "multiply"
    public Person ProcreateWith(Person partner, string name)
    {
        return Procreate(this, partner, name);
    }

    public int MethodIWantToCall(string input)
    {
        return input.Length; // it doesn't matter what the method does
    }

    // implicit implementation
    public void Lose()
    {
        Console.WriteLine("Key Lose Method Called Implicitly");
    }

    // explicit implementation
    void IGamePlayer.Lose()
    {
        Console.WriteLine("Game Lose Method Called Explicitly");
    }
}
