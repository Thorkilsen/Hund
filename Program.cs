using System;
using System.Collections.Generic;
using Hund;

namespace DogClub
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            List<Dog> dogs = new List<Dog>();

            // Jens-ole Mccoy
            Member member1 = new Member(1, "Jens-ole Mccoy", "Malmvej 27, Roskilde", new DateTime(1950, 5, 12), "76432819", "jensmccoy2@gmail.com");
            Dog dog1 = new Dog(1, "Fido", Race.Labrador, 2018);

            members.Add(member1);
            dogs.Add(dog1);

            member1.RegisterDog(dog1);

            // Anna Pedersen med flere hunde
            Member member2 = new Member(2, "Anna Pedersen", "rosenvænget 97, Roskilde", new DateTime(1985, 3, 22), "87654321", "annahund27@gmail.com");
            Dog dog2 = new Dog(2, "Bella", Race.Poodle, 2020);
            Dog dog3 = new Dog(3, "Tonic", Race.GermanShepherd, 2019);
            Dog dog4 = new Dog(4, "Ally", Race.Bulldog, 2021);

            members.Add(member2);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);

            member2.RegisterDog(dog2);
            member2.RegisterDog(dog3);
            member2.RegisterDog(dog4);


            members.Add(member2);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);

            member2.RegisterDog(dog2);
            member2.RegisterDog(dog3);
            member2.RegisterDog(dog4);

            // Test ToString metoder
            Console.WriteLine(member1);
            Console.WriteLine(dog1);

            Console.WriteLine(member2);
            Console.WriteLine(dog2);
            Console.WriteLine(dog3);
            Console.WriteLine(dog4);

            // Test beregning af kontingent
            Console.WriteLine($"Kontingent for {member1.Name} er: {member1.CalculateMemberFee()} kr.");
            Console.WriteLine($"Kontingent for {member2.Name} er: {member2.CalculateMemberFee()} kr.");
        }
    }
}


