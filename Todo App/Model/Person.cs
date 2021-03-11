using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_App.Model
{
    public class Person
    {
        // Fields 
        public static int idCounter = 0 ;           // Skall vara private

        private string firstName;
        private string lastName;
        private int personId;                      //  Skall vara readonly 


        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName                    // Public string name property
        {
            get     // If somebody wants to access this Firstname property they will get firstname in return, act as a get-method
            {
                return firstName;   // If somebody try to access from outside they will get what is in this code block, firstName
            }

            set
            {
                if (string.IsNullOrEmpty(value))   // Indicates whether the specified string is Null or an empty string
                {
                    firstName = value;             // This value is only valid when inside the property "set"
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
                if (string.IsNullOrEmpty(value))    // Indicates whether the specified string is Null or an empty string
                {
                    firstName = value;              // This value is only valid when inside the property "set"
                }
            }
        }


        public Person()
        {
            Id = ++idCounter;
        }
    }
}
