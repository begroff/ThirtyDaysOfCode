using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode;
using System.Collections.Generic;

namespace SandboxTests.ThirtyDaysOfCode
{
    [TestClass]
    public class PallindromeTests
    {

        public void String_Is_A_Palindrome()
        {
            Palindrome palindrome = new Palindrome();
            bool isPalindrome = false;
            bool isNotPalindrome = true;

            string[] testStrings = {
                "racecar",
                "hello",
            };

            isPalindrome = palindrome.CheckForPalindrome(testStrings[0]);
            isNotPalindrome = palindrome.CheckForPalindrome(testStrings[1]);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(isNotPalindrome);
        }
    }
}