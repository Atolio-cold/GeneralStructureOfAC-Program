using System;

public class Customer
{
    // Fields
    private string name;
    private string email;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            // Można dodać walidację wieku
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age cannot be negative");
            }
        }
    }

    // Constructor
    public Customer(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Pobieranie danych od użytkownika
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();

        Console.WriteLine("Enter your email:");
        string userEmail = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        int userAge;

        // Walidacja wieku
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userAge) && userAge >= 0)
            {
                break; // Wyjdź z pętli, jeśli wiek jest poprawny
            }
            else
            {
                Console.WriteLine("Please enter a valid age (non-negative integer):");
            }
        }

        // Tworzenie obiektu klasy Customer z danych wprowadzonych przez użytkownika
        Customer customer1 = new Customer(userName, userEmail, userAge);
        
        // Wyświetlanie informacji o kliencie
        customer1.DisplayInfo();
    }
}
