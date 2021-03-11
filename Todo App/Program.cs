using System;
using Todo_App.Model;

namespace Todo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Person static counter: " + Person.idCounter);

            Person person1 = new Person();
            Console.WriteLine("Person static counter: " + Person.idCounter);

            Person person2 = new Person();
            Console.WriteLine("Person static counter: " + Person.idCounter);

            Person person3 = new Person();
            Console.WriteLine("Person static counter: " + Person.idCounter);


            Console.WriteLine("Person with id: " + person1.Id);
            Console.WriteLine("Person with id: " + person2.Id);
            Console.WriteLine("Person with id: " + person3.Id);

        }
    }
}
