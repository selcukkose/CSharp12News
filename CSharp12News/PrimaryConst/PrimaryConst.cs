namespace CSharp12News.PrimaryConst;

// Parameters used with primary constructor are usable in the class scope
public class PrimaryConst(string name, int age)
{
    // Primary Constructor parameters are can't be access from outside of the class
    // Primary Constructor parameters can be used to initialize properties
    public string Name { get; init; } = name;
    public int Age { get; init; } = age;
    public string Title { get; set; } = string.Empty;
    
    public PrimaryConst(string name, int age, string title) : this(name, age)
    {
        name = $"{name} something"; // primary constructor parameters are can be changed
        Name = name;
        Age = age;
        Title = title;
    }
    
    public override string ToString() => $"Name: {name}, Age: {Age}, Title: {Title}";
}

// Dependency Injection is easier
// public class ExampleController(IService service) : ControllerBase
// {
//     [HttpGet]
//     public ActionResult<Distance> Get()
//     {
//         return service.GetDistance();
//     }
// }