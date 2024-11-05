class Customer
{
    public string Name { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Customer Name: {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektów
        Customer object1 = new Customer { Name = "Alice" };
        Customer object2; // Tylko zadeklarowana, nieużywana

        Customer object3 = new Customer { Name = "Bob" };
        Customer object4 = object3; // object4 i object3 wskazują na ten sam obiekt

        // Wyświetlenie informacji
        object1.DisplayInfo(); // Alice
        object3.DisplayInfo(); // Bob
        object4.DisplayInfo(); // Bob (ten sam obiekt co object3)

        // Zmiana nazwy przez object4
        object4.Name = "Charlie";
        
        // Sprawdzenie zmiany przez oba obiekty
        object3.DisplayInfo(); // Charlie (zmiana widoczna przez object3)
        object4.DisplayInfo(); // Charlie
    }
}

