using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeAlgo = FastPrimeFactoringAlgorithm;

namespace UnitTestApplication
{
  [TestClass]
  public class UnitTestFastPrime
  {
    [TestMethod]
    public void TestMethodFactorizeToString()
    {
      string result = FastPrimeFactoringAlgorithm.Integers.FactorizeToString(11);
      string expected = "11 = 11 * 1";
      Assert.AreEqual(result, expected);

      result = FastPrimeFactoringAlgorithm.Integers.FactorizeToString(4);
      expected = "4 = 2 * 2 * 1";
      Assert.AreEqual(result, expected);

      result = FastPrimeFactoringAlgorithm.Integers.FactorizeToString(32);
      expected = "32 = 2 * 2 * 2 * 2 * 2 * 1";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodIsPrime()
    {
      bool result = FastPrimeFactoringAlgorithm.Integers.IsPrime(11);
      Assert.IsTrue(result);

      result = FastPrimeFactoringAlgorithm.Integers.IsPrime(7);
      Assert.IsTrue(result);

      result = FastPrimeFactoringAlgorithm.Integers.IsPrime(8);
      Assert.IsFalse(result);

      result = FastPrimeFactoringAlgorithm.Integers.IsPrime(9);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethodFactorizeFast()
    {
      int numberToTest = 11;
      string expected2 = numberToTest + " = 11 * 1";
      string expected = numberToTest + " = ";
      Int64[] result = FastPrimeFactoringAlgorithm.Integers.FactorizeFast(numberToTest);
      foreach (Int64 number in result)
      {
        expected += number + " * ";
      }

      expected += "1";
      Assert.AreEqual(expected, expected2);

      numberToTest = 40;
      expected2 = numberToTest + " = 2 * 2 * 2 * 5 * 1";
      expected = numberToTest + " = ";
      result = FastPrimeFactoringAlgorithm.Integers.FactorizeFast(numberToTest);
      foreach (Int64 number in result)
      {
        expected += number + " * ";
      }

      expected += "1";
      Assert.AreEqual(expected, expected2);
    }

    [TestMethod]
    public void TestNumberOfPrimeWithinRange()
    {
      Assert.AreEqual(3, CountPrimeWithinRange(8));
      Assert.AreEqual(4, CountPrimeWithinRange(12));
      Assert.AreEqual(10, CountPrimeWithinRange(32));
      Assert.AreEqual(20, CountPrimeWithinRange(74));
      Assert.AreEqual(30, CountPrimeWithinRange(128));
      Assert.AreEqual(40, CountPrimeWithinRange(180));
    }

    private static int CountPrimeWithinRange(int upperLimit)
    {
      int count = 0;
      for (int i = 3; i < upperLimit; i++)
      {
        if (FastPrimeFactoringAlgorithm.Integers.IsPrime(i))
        {
          count++;
        }
      }

      return count;
    }

    [TestMethod]
    [DataRow("", "abc", "abc")]
    public void TestMethod1(string first, string second, string result)
    {
      Assert.AreEqual<string>(result, first + second);
    }

    [TestMethod]
    public void TestMethod2()
    {
      const bool result = true;
      Assert.IsTrue(result);
    }

    private class DataRowAttribute : Attribute
    {
      public string first { get; set; }
      public string second { get; set; }
      public string result { get; set; }
      public DataRowAttribute(string first, string second, string result)
      {
        this.first = first;
        this.second = second;
        this.result = result;
      }
    }
  }
}