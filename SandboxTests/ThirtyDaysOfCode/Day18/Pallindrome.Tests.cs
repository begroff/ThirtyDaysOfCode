using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.ThirtyDaysOfCode.Day18;
using System.Collections.Generic;

namespace SandboxTests.ThirtyDaysOfCode.Day18
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