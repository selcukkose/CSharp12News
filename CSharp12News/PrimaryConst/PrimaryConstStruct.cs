namespace CSharp12News.PrimaryConst;

// Primary Constructor can be used on Structs too but they can't be used with Records
public struct PrimaryConstStruct(string name, int age)
{
    public string Name { get; init; } = name;
    public int Age { get; init; } = age;
    public string Title { get; set; } = string.Empty;
    
    public PrimaryConstStruct(string name, int age, string title) : this(name, age)
    {
        name = $"{name} something";
        Name = name;
        Age = age;
        Title = title;
    }
    
    public override string ToString() => $"Name: {name}, Age: {Age}, Title: {Title}";
}