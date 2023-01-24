using System;
public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }
    public AgeGroupEnmeration AgeGroup { get; set; }
}

public enum AgeGroupEnmeration : short
{
    Child = 100, Teenager, Adult, Senior
}
