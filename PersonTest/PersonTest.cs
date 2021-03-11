using System;
using Todo_App.Model;
using Xunit;

namespace PersonTest
{
    public class PersonTest
    {
        [Fact]
        public void PersonIdTest()
        {
            // Arrange
            Person testPerson = new Person();

            // Act
            int result = testPerson.Id;

            // Assert
           Assert.NotEqual( 0,result);
        }
         
        
      
       [Fact]
       public void PersonUniqueIdTest()
       { 
            // Arrange
            Person testPerson1 = new Person();
            Person testPerson2 = new Person();
            Person testPerson3 = new Person();

            // Act
            int result1 = testPerson1.Id;
            int result2 = testPerson2.Id;
            int result3 = testPerson3.Id;

            // Assert
            //Assert.Equal(1, result1);
            //Assert.Equal(2, result2);
            //Assert.Equal(3, result3);

            Assert.True(result1 != result2 && result1 != result3);  // Make sure the testing order is independent
            Assert.True(result2 != result1 && result2 != result3);
            Assert.True(result3 != result1 && result3 != result1);

       }

    }
}
