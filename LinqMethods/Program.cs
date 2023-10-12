using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        string fullName = string.Concat(firstName, " ", lastName);



        List<string> names = new List<string>
        {
            "Alice", "Bob", "Alice", "Charlie", "Bob", "David"
        };


        var uniqueNames = names.Distinct().ToList();

        Console.WriteLine("Benzersiz İsimler:");
        foreach (var name in uniqueNames)
        {
            Console.WriteLine(name);
        }




        List<string> names = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eva", "Frank"
        };

        int numberOfItemsToSkip = 2;


        var skippedNames = names.Skip(numberOfItemsToSkip).ToList();

        Console.WriteLine($"{numberOfItemsToSkip} öğe atlandı:");
        foreach (var name in skippedNames)
        {
            Console.WriteLine(name);
        }




        List<string> names = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eva", "Frank"
        };

        int numberOfItemsToTake = 3;


        var selectedNames = names.Take(numberOfItemsToTake).ToList();

        Console.WriteLine($"{numberOfItemsToTake} öğe seçildi:");
        foreach (var name in selectedNames)
        {
            Console.WriteLine(name);
        }


        List<string> names = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eva", "Frank"
        };

        // Öğeleri alfabetik olarak sırala (küçükten büyüğe)
        var sortedNames = names.OrderBy(name => name).ToList();

        Console.WriteLine("Sıralı İsimler (Küçükten Büyüğe):");
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }


        List<string> names = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eva", "Frank"
        };

        // Her ismi büyük harfle yeni bir koleksiyona projeksiyon yapma
        var upperCaseNames = names.Select(name => name.ToUpper()).ToList();

        Console.WriteLine("İsimler Büyük Harfle:");
        foreach (var name in upperCaseNames)
        {
            Console.WriteLine(name);
        }

    }
}

