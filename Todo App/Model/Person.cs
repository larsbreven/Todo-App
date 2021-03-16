using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_App.Model
{
    public class Person
    {
        //Fields
        public readonly int personId;

        public string firstName;
        public string lastName;


        public Person(int personId, string firstName, string lastName)  // Constructor building the object
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Id//readonly kan ej ha set;
        {
            get { return personId; }
        }

        public string FirstName
        {
            get//läs
            {
                return firstName;
            }
            set//skriv
            {
                if ( ! string.IsNullOrEmpty(value))
                {
                    firstName = value;//"value" finns bara i "set" det innehåller var dom vill ändra firstName till.
                }
            }
        }

        public string LastName
        {
            get//läs
            {
                return lastName;
            }
            set//skriv
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;//"value" finns bara i "set" det innehåller var dom vill ändra lastName till.
                }
            }
        }

    }
}