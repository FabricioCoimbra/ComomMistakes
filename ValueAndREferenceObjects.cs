using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        List<SimpleClient> otherClientList = new(){ new() { Id = 4, Name = "Abigail" } };
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
    }
}
