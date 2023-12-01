using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public Person(string firstName, string lastName, string city, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        City = city;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "San Francisco", 41),
            new Person("Sarah", "Jones", "San Francisco", 22),
            new Person("Stacy", "Baker", "New York", 21),
            new Person("John", "Doe", "Dallas", 30),
            new Person("Alice", "Johnson", "Dallas", 28)
        };

        string targetCity = "Dallas";

        int sumOfAgesInDallas = people
            .Where(p => p.City == targetCity)
            .Sum(p => p.Age);

        Console.WriteLine($"A soma das idades das pessoas em {targetCity} é: {sumOfAgesInDallas}");
        Console.ReadLine();
    }
}
