namespace CSharp12News.PrimaryConst;

// Even if we don't use primary constructor, we can still use primary constructor im child classes
public class InitBase(string name) : BaseClass(name)
{
    
}

public class BaseClass
{
    private string Name { get; set; }
    public BaseClass(string name)
    {
        Name = name;
    }

    public string SomeMethod() => $"Hello From Some Method {Name}";
}