using System;
using System.Collections.Generic;

namespace PersonManagement
{
    // Definicja wyliczenia dla płci
    enum Gender
    {
        Male,
        Female,
        Other
    }

    // Definicja struktury dla adresu
    struct Address
    {
        public string Street;
        public string City;
        public string ZipCode;

        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }

    // Definicja interfejsu dla osoby
    interface IPerson
    {
        string GetFullName();
        void DisplayInfo();
    }

    // Klasa implementująca interfejs
    class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }

        public Person(string firstName, string lastName, Gender gender, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {GetFullName()}, Gender: {Gender}, Address: {Address.Street}, {Address.City}, {Address.ZipCode}");
        }
    }

    // Delegat do wyświetlania informacji o osobach
    delegate void DisplayPersonInfo(IPerson person);

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie listy osób
            List<IPerson> people = new List<IPerson>();

            // Dodawanie osób do listy
            people.Add(new Person("John", "Doe", Gender.Male, new Address("123 Main St", "Springfield", "12345")));
            people.Add(new Person("Jane", "Smith", Gender.Female, new Address("456 Elm St", "Springfield", "12345")));
            people.Add(new Person("Alex", "Taylor", Gender.Other, new Address("789 Oak St", "Springfield", "12345")));

            // Użycie delegata do wyświetlania informacji o osobach
            DisplayPersonInfo displayInfo = person => person.DisplayInfo();

            // Wyświetlanie informacji o wszystkich osobach
            foreach (var person in people)
            {
                displayInfo(person);
            }
        }
    }
}
