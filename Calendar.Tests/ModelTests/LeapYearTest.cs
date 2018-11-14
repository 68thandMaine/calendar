using Microsoft.VisualStudio.TestTools.UnitTesting; //Imports the packages from the csproj file
using Calendar; // imports the namespace from the Calendar project

namespace Calendar.Tests
{
  [TestClass] // Tells the MSTest package to run the code contained here
  public class LeapYearTest
  {
    [TestMethod] // Tells the compiler that this code should be run by MSTest
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      // The code below creates an instance of the LeapYear class called testLeapYear. The Assert method AreEqual() is then called on the value true and the expected behavior of the app. In this case it sees if 2012 is divisible by four and compares it to a true boolean.
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }
    [TestMethod] // New TestMethods must be contained within their own public voids.
    public void IsLeapYear_NumberDivisibleByFour_False()
    {
      // The next simplest behavior this program will exhibit should be checking if a number is not divisible by four. The code below checks to see if a false = false statement is given to the AreEqual method.
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }
  }
}
