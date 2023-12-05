
using System;

var age = 19;
var gender = "men";

if (gender == "women" && age > 18)
{
    Console.WriteLine("Pełnoletnia kobieta");
}
else if (gender == "women" && age < 18)
{
    Console.WriteLine("Niepełnoletnia dziewczyna");
}
else
{
    if (age > 18)
    {
        Console.WriteLine("Pełnoletni męższczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletni chłopak");
    }
}