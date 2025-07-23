using System;

namespace Encapsulation2
{
    public class Person
    {
        private string _name;
        private int _age;
        private int _id;
        private string _occupation;

        public Person(string name, int age, int id, string occupation)
        {
            Name = name;
            Age = age;
            Id = id;
            Occupation = occupation;


        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.", nameof(value));
                _name = value.Trim();
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 0 and 120.");
                _age = value;
            }
        }

        public int Id
        {
            get => _id;

            set
            {
                if (value < 0 || value > 9999999)
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid ID Number");
                _id = value;
            }
        }

        public string Occupation
        {
            get => _occupation;

            set
            {
                if (string.IsNullOrWhiteSpace("Occupation cannot be blank")) ;
                _occupation = value;
            }
        } 

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} with the ID of {Id} and I'm {Age} years old.\nI work as {Occupation}");
        }
    }
}