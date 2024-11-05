using System;

class MyClass
{
    public int Value { get; set; }

    public MyClass(int initialValue)
    {
        Value = initialValue;
    }

    public void DisplayValue()
    {
        Console.WriteLine($"The value is: {Value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektu myClass1
        MyClass myClass1 = new MyClass(10);
        
        // Przypisanie referencji do myClass1 do myClass2
        MyClass myClass2 = myClass1;

        // Wyświetlanie wartości
        myClass1.DisplayValue(); // Wyświetli: The value is: 10
        myClass2.DisplayValue(); // Wyświetli: The value is: 10

        // Zmiana wartości przez myClass2
        myClass2.Value = 20;

        // Sprawdzenie wartości w obu obiektach
        myClass1.DisplayValue(); // Wyświetli: The value is: 20
        myClass2.DisplayValue(); // Wyświetli: The value is: 20
    }
}
