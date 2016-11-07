using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValaApplication;
using ValaApplication.Controllers;

namespace ValaApplication.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            HelloController controller = new HelloController();

            // Act
            String result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
           
            Assert.AreEqual("World!", result);
            
        }

    }
}
