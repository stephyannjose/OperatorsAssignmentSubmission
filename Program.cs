using System;

// Define the Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects by their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both objects are null, or both objects are the same object, return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one of the objects is null, or their Id properties are not equal, return false
        if (emp1 is null || emp2 is null || emp1.Id != emp2.Id)
            return false;

        // Otherwise, return true if their Id properties are equal
        return true;
    }

    // Overload the "!=" operator to complement the overloaded "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the negation of the result of the overloaded "=="
        return !(emp1 == emp2);
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using the overloaded "==" operator
        if (emp1 == emp2)
        {
            Console.WriteLine("Employee objects are equal.");
        }
        else
        {
            Console.WriteLine("Employee objects are not equal.");
        }
    }
}
