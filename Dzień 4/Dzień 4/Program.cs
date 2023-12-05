var age = 26;
var name = "Kasia";
var gender = "women";
if (gender == "women")
{
    if (name == "Kasia")
    {
        if (age == 33)
        {
            Console.WriteLine("Kobieta o imieniu Kasia,lat 33");
        }
        else if (age > 33)
        {
            Console.WriteLine("Kobieta o imieniu Kasia powyżej trzydziestu trzech lat");
        }
        else if (age < 33)
        {
            Console.WriteLine("Kobieta o imieniu Kasia poniżej trzydziestu trzech lat");
        }
    }
    else
    {
        if (age == 33)
        {
            Console.WriteLine("Kobieta lat 33");
        }
        else if (age > 33)
        {
            Console.WriteLine("Kobieta powyżej trzydziestu trzech lat");
        }
        else if (age < 33)
        {
            Console.WriteLine("Kobieta poniżej trzydziestu trzech lat");
        }
    }
}
else
{
    if (age == 33)
    {
        Console.WriteLine("Ktoś w wieku 33");
    }
    else if (age > 33)
    {
        Console.WriteLine("Ktoś powyżej trzydziestu trzech lat");
    }
    else if (age < 33)
    {
        Console.WriteLine("Ktoś poniżej trzydziestu trzech lat");
    }

}
