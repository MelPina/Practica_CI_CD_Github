using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Controllers;
using Xunit;

namespace WebApplication
{
    public class UnitTest1
    {
      
            [Fact]
            public void TestHelloWorld()
            {
                // Arrange
                var controller = new HomeController();

                // Act
                var result = controller.Index() as ContentResult;

                // Assert
                Assert.NotNull(result);
                Assert.Equal("Hola Mundo desde C#!", result.Content);
            }
        
    }
}