using Microsoft.VisualStudio.TestTools.UnitTesting;
using PChecker;

namespace PChecker.TestTools
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsWord_AWordAWord_True()
    {
      Palindrome testP = new Palindrome();
      Assert.AreEqual(true, testP.IsWord("test"));
    }
    // [TestMethod]
    // public void IsPalindrome_SameForwardAndBackward_True()
    // {
    //   Palindrome testP = new Paldrome();
    //   Assert. // (true, testP.IsPalindrome());
    // }
  }
}