using System;
using System;
using System.Collections.Generic;
using Hund;

namespace Hund
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs { get; set; }

        public Member(int id, string name, string address, DateTime birthDate, string phone, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Dogs = new List<Dog>();
        }

        public void RegisterDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;

            }
        }

        public double CalculateMemberFee()
        {
            int numberOfDogs = Dogs.Count;
            double fee = 1000; // første hund

            if (Age >= 65)
            {
                fee /= 2; // Halverer første hundens kontingent hvis man er over 65
            }

            if (numberOfDogs > 1)
            {
                fee += (numberOfDogs - 1) * 500; // Halv pris for hund nummer 2+
            }

            if (numberOfDogs > 5)
            {
                fee = 2500; // Fastlagt kontingent
            }

            return fee;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Address: {Address}, BirthDate: {BirthDate.ToShortDateString()}, Phone: {Phone}, Email: {Email}, Dogs: {Dogs.Count}";
        }
    }
}


