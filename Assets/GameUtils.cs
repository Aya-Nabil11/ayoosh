using System.Collections;
using System.Collections.Generic;

public static class GameUtils
{
    // Static method to describe an item
    public static string DescribeItem<T>(T something)
    {
        return "This item is " + something.ToString();
    }
}
