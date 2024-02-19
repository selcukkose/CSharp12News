namespace CSharp12News.DefaultValueForLambda;

public class DefaultValueForLambda
{
    // By C# 12, we can use default values for lambda expressions
    public string SomeMethod(string name = "Selçuk", int age = 28) => $"Name: {name}, Age: {age}";
}