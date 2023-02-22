using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System.Collections.Generic;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests : IDisposable
  {
    public void Dispose()
    {
      // Code inside this method is run between each test.
    }
    
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // we can also use the arrange, act, assert organization in any test. 
      Assert.AreEqual(ExpectedResult, CodeToTest);
    }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // we can also use the arrange, act, assert organization in any test. 
      CollectionAssert.AreEqual(ExpectedResult, CodeToTest);
    }
  }
}