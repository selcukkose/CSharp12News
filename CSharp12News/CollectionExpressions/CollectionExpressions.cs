using System.Text;

namespace CSharp12News.CollectionExpressions;

public class CollectionExpressions
{
    // Instead of typing List<string> stringList = new List<string> { "one", "two", "three", "four", "five" };
    // We can use the following syntax
    int[] numberArray = [1, 2, 3, 4, 5, 6, 7, 8];
    List<string> stringList = ["one", "two", "three", "four", "five"];

    public string JoinLists()
    {
        var joined = new StringBuilder(string.Empty);
        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, 9];
        // The "Spread Operator" which widely used operator in JavaScript is now available in C# 12
        // The Spread Operator is used to spread the elements of an array or object
        // By using the Spread Operator, we can easily join the arrays
        int[] single = [.. row0, .. row1, .. row2];
        foreach (var element in single)
        {
            joined.Append($"{element}, ");
        }

        return joined.ToString();
    }
}