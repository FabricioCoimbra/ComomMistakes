﻿namespace ComomMistakes;

public class SimpleClient
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public override string ToString()
    {
        return $"{Id}:{Name} , ";
    }
}
