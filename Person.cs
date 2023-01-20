public class Person
{
    public string firstName;
    public string lastName;

    public Person(string setFirstName, string setLastName)
    {
        firstName = setFirstName;
        lastName = setLastName;
    }

    public void setFirstName(string setFirstName)
    {
        firstName = setFirstName;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public void setLastName(string setLastName)
    {
        lastName = setLastName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {firstName} {lastName}");
    }

    public static string goodbye()
    {
        return ("Goodbye");
    }
}
