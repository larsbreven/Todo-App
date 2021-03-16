using System;
using Xunit;
using Todo_App.Model;

namespace Todo_App.Tests
{
    public class PersonTests
    {
        [Fact]
        public void PersonConstructorTest()
        {
            //Arrange
            int testId = 666;
            string firstName = "ulf";
            string lastName = "bengtsson";

            //Act
            Person testPerson = new Person(testId, firstName, lastName);

            //Assert
            Assert.Equal(testId, testPerson.Id);
            Assert.Equal(firstName, testPerson.FirstName);
            Assert.Equal(lastName, testPerson.LastName);
        }

        [Fact]
        public void PropFirstNameNotNullChange()
        {
            //Arrange
            int testId = 666;
            string firstName = "ulf";
            string badNullFirstName = null;
            string lastName = "bengtsson";
            Person testPerson = new Person(testId, firstName, lastName);

            //Act
            testPerson.FirstName = badNullFirstName;

            //Assert

            Assert.NotEqual(badNullFirstName, testPerson.FirstName);
            Assert.Equal(firstName, testPerson.FirstName);

        }

        [Fact]
        public void PropFirstNameNotEmptyChange()
        {
            //Arrange
            int testId = 666;
            string firstName = "ulf";
            string badEmptyFirstName = "";
            string lastName = "bengtsson";
            Person testPerson = new Person(testId, firstName, lastName);

            //Act
            testPerson.FirstName = badEmptyFirstName;

            //Assert

            Assert.NotEqual(badEmptyFirstName, testPerson.FirstName);
            Assert.Equal(firstName, testPerson.FirstName);

        }

        [Fact]
        public void PropLastNameNotNullChange()
        {
            //Arrange
            int testId = 666;
            string firstName = "ulf";
            string badNullLastName = null;
            string lastName = "bengtsson";
            Person testPerson = new Person(testId, firstName, lastName);

            //Act
            testPerson.LastName = badNullLastName;

            //Assert

            Assert.NotEqual(badNullLastName, testPerson.LastName);
            Assert.Equal(lastName, testPerson.LastName);

        }

        [Fact]
        public void PropLastNameNotEmptyChange()
        {
            //Arrange
            int testId = 666;
            string firstName = "ulf";
            string badEmptyLastName = "";
            string lastName = "bengtsson";
            Person testPerson = new Person(testId, firstName, lastName);

            //Act
            testPerson.LastName = badEmptyLastName;

            //Assert

            Assert.NotEqual(badEmptyLastName, testPerson.LastName);
            Assert.Equal(lastName, testPerson.LastName);

        }

        //[Fact]
        //public void Test()
        //{
        //    //Arrange
        //    int testId = 666;
        //    string firstName = "ulf";
        //    string lastName = "bengtsson";
        //    Person testPerson = new Person(testId, firstName, lastName);

        //    //Act
        //    testPerson.Id = 111;//readonly compile error

        //    //Assert
        //}
    }
}
