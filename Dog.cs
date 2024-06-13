using System;

namespace Hund

{
    public enum Race
    {
        Labrador,
        Poodle,
        GermanShepherd,
        Bulldog,
        
    }

    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Race Race { get; set; }
        public int YearOfBirth { get; set; }

        public Dog(int id, string name, Race race, int yearOfBirth)
        {
            ID = id;
            Name = name;
            Race = race;
            YearOfBirth = yearOfBirth;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Race: {Race}, YearOfBirth: {YearOfBirth}";
        }
    }
}
