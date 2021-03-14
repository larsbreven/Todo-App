using System;
using Todo_App.Model;
using Xunit;

namespace PersonTest
{
    public class PersonTest
    {
        [Fact]
        public void PersonIdTest()                      // Test method to check the Id is not 0
        {
            Person testPerson = new Person();           // Arrange
            int result = testPerson.Id;                 // Act
            Assert.NotEqual(0, result);                 // Assert
        }

        [Fact]
        public void PersonUniqueIdTest()                // Test method to make sure the testing order is independent
        {
            Person testPerson1 = new Person();          // Arrange
            Person testPerson2 = new Person();
            Person testPerson3 = new Person();
                
            int result1 = testPerson1.Id;               // Act
            int result2 = testPerson2.Id;
            int result3 = testPerson3.Id;

            Assert.True(result1 != result2 && result1 != result3);  // Assert
            Assert.True(result2 != result1 && result2 != result3);
            Assert.True(result3 != result1 && result3 != result1);
        }

    }
}
