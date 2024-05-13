using System.Runtime.InteropServices;
using Basic;
using Encapsulation;

Console.WriteLine("Hello, World!");

var person1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));
var person2 = new Person("Jane", "Doe", new DateOnly(1995, 1, 1));

person1.pets.Add(new Cat("Fluffy"));
person1.pets.Add(new Dog("Rocky"));

person2.pets.Add(new Cat("Whiskers"));
person2.pets.Add(new Dog("Rex"));

List<Person> people = [person1, person2];


foreach (var person in people)
{
    Console.WriteLine($"{person}");
    foreach (var pet in person.pets)
    {
        Console.WriteLine($"{pet}");
    }
}

var p1 = new Point(3, 4);
Console.WriteLine(p1.X);


var r1 = new Rectangle(100, 20, new Point(0, 0));
Console.WriteLine(r1);
Console.WriteLine(r1.GetArea());
Console.WriteLine(r1.GetPerimeter());


Console.WriteLine(Species.FromFullName("Cannabis Sativa"));



var account = new BankAccount("Samwel", 1000);
account.Deposit(500);
account.WithDraw(200);
Console.WriteLine(account.GetBalance());




public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string firstName { get; set; } = firstName;
    public string lastName { get; set; } = lastName;
    public DateOnly birthday { get; set; } = birthday;

    public List<Pet> pets { get; set; } = new();

    public override string ToString()
    {
        return $"Human {firstName} {lastName} was born on {birthday:yyyy-MM-dd}.";
    }
}

public abstract class Pet(string firstName)
{
    public string firstName { get; set; } = firstName;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{firstName} and I am a {GetType().Name} and I {MakeNoise()}.";
    }
}

public class Cat(string firstName) : Pet(firstName)
{
    public override string MakeNoise()
    {
        return "Meow!";
    }
}

public class Dog(string firstName) : Pet(firstName)
{
    public override string MakeNoise()
    {
        return "Woof!";
    }
}