using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_App.Model
{
    public class Person
    {
        //Fields
        public static int idCounter = 0;            // Skall vara private
        public string firstName;
        public string lastName;
        public int personId;                        //  Skall vara readonly 


        public void Citizen(int personId, string firstName, string lastName)  // Constructor building the object
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Id { get; set; }

        public string Brand { get; set; }

        public string ModelName { get; set; }



        public Person()
        {
            Id = ++idCounter;
        }
    }
}