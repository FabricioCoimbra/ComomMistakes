using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

#nullable disable

namespace ComomMistakes;

public static class ValueAndREferenceObjects
{
    public static void ManagaListsObjects()
    {
        Console.WriteLine("Creating lists and objects");

        List<SimpleClient> originalClientList = new()
            {
                new() { Id = 1, Name = "Teobaldo" },
                new() { Id = 2, Name = "Tiburcio" },
                new() { Id = 3, Name = "Pafuncia" }
            };

        List<SimpleClient> otherClientList = new() { new() { Id = 4, Name = "Abigail" } };
        otherClientList.AddRange(originalClientList);

        originalClientList.Add(new() { Id = 4, Name = "Monica" });

        Console.WriteLine($"Original List = {string.Join("", originalClientList)}");
        Console.WriteLine($"Other List = {string.Join("", otherClientList)}");

        Console.WriteLine("");
        Console.WriteLine("Updating objects");
        Console.WriteLine("");

        var teobaldo = originalClientList.Find(x => x.Id == 1);
        teobaldo.Name = " Teobaldo Updated";

        Console.WriteLine($"Original List = {string.Join("", originalClientList)}");
        Console.WriteLine($"Other List = {string.Join("", otherClientList)}");

        List<SimpleClient> ClonedList = new() { new() { Id = 5, Name = "Martha" } };

        ClonedList.AddRange(originalClientList.Select(x => CopyObject(x)).ToList());

        var tiburcio = originalClientList.Find(x => x.Id == 2);
        tiburcio.Name = " Tiburcio Updated ";

        Console.WriteLine($"Original List = {string.Join("", originalClientList)}");
        Console.WriteLine($"Other List = {string.Join("", otherClientList)}");
        Console.WriteLine($"Cloned List = {string.Join("", ClonedList)}");
    }

    private static T CopyObject<T>(T SourceObject) where T : class =>
        JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(SourceObject));
}
