using System;
using System.Collections.Generic;

namespace PersonManagement
{
    
    enum Gender
    {
        Male,
        Female,
        Other
    }

    
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

    interface IPerson
    {
        string GetFullName();
        void DisplayInfo();
    }

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

    delegate void DisplayPersonInfo(IPerson person);

    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();

            people.Add(new Person("John", "Doe", Gender.Male, new Address("123 Main St", "Springfield", "12345")));
            people.Add(new Person("Jane", "Smith", Gender.Female, new Address("456 Elm St", "Springfield", "12345")));
            people.Add(new Person("Alex", "Taylor", Gender.Other, new Address("789 Oak St", "Springfield", "12345")));

            DisplayPersonInfo displayInfo = person => person.DisplayInfo();

            foreach (var person in people)
            {
                displayInfo(person);
            }
        }
    }
}
