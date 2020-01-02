using System;
using System.Collections.Generic;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname;
        string lastname;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstname = "Mateusz";
            lastname = "Kowalski";
            address = "szkolna 11/20";
            age = 23;
            gender = "mężczyzna";
        }

        public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {
            this.id = id; 
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

    }
}