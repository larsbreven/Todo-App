using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_App.Model
{
    class Person
    {
        private string firstName;
        private string lastName;
        private readonly int personId;



        public Person(string firstName, string lastName, int personId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personId = personId;
        }
        public string FirstName                         // Public string name property
        {
            get     // If somebody wants to access this FirstName property they will get firstname in return, acts as a get-method
            {
                return firstName;   // If somebody try to access from outside they will get what is in this code block, firstName
            }
            set
            {

                if (string.IsNullOrEmpty(value))    // Indicates whether the specified string is Null or an empty string "" 
                {
                    firstName = value;              // This value is only valid when we are inside the property "set"
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))    // Indicates whether the specified string is Null or an empty string "" 
                {
                    lastName = value;
                }
            }
        }
    }
}
