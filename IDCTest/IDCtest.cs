using IDC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IDCTest
{
    [TestClass]
    public class IDCtest
    {
        [TestMethod]
        [DataRow("abdcefghijklmnopqrstuvwxyz", 26)]
        [DataRow("abcdefghalghnhwqh", 17)]
        [DataRow("12344566789101112", 17)]
        [DataRow("______$$$$$$44444", 17)]
        [DataTestMethod]
        public void DoesLengthOfStringMatch(string token,int expected)
        {
            ITokenActions tokenAction = new TokenActions();
            int length = tokenAction.LenthOfString(token);
            Assert.AreEqual(expected, length);

        }

        [TestMethod]
        [DataRow("4_________4444444_____", true)]
        [DataRow("$4____________________", false)]
        [DataTestMethod]
        public void DoesItReturnEmptyString(string token, bool expected)
        {
            ITokenActions tokenAction = new TokenActions();
            bool isEmpty = tokenAction.TokenReturnsEmptyString(token);
            Assert.AreEqual(expected, isEmpty);
        }

        [TestMethod]
        [DataRow("4_________4444444_____","")]
        [DataRow("$4____________________","$")]
        [DataTestMethod]
        public void IsUnderscoreOrNumberFourRemoved(string token,string expected)
        {
            ITokenActions tokenAction = new TokenActions();
            string test = tokenAction.RemoveUnderscoresAndNumberFour(token);
            
            Assert.AreEqual(test,expected);
        }

        [TestMethod]
        [DataRow("4_________4444444_____", "4_")]
        [DataRow("$4____________________", "$4_")]
        [DataRow("4ABb_", "4ABb_")]
        [DataTestMethod]
        public void AreDuplicatesRemovedFromString(string token,string expected)
        {
            ITokenActions tokenAction = new TokenActions();
            string test = tokenAction.RemoveDuplicateCharacters(token);

            Assert.AreEqual(test, expected);
           
        }

        [TestMethod]
        [DataRow("$$$_________4444444___£$£", "£££_________4444444___£££")]
        [DataRow("$____________________", "£____________________")]
        [DataRow("____________________", "____________________")]
        public void AreDollarSignChangedToPoundSign(string token, string expected)
        {
            ITokenActions tokenAction = new TokenActions();
            string test = tokenAction.ChangeDollarToPoundSign(token);

            Assert.AreEqual(test, expected);
        }

        [TestMethod]
        [DataRow("Abcefghklmnopyzx111cJCDNDJ", "Abcefghklmnopyz")]
        [DataRow("123456789101112 _", "123456789101112")]
        
        public void DoesItTruncateToFifteenCharaters(string token, string expected)
        {
            ITokenActions tokenAction = new TokenActions();
            string test = tokenAction.TruncateTokenToFifteenChars(token);
            
            Assert.AreEqual(test, expected);
            Assert.AreEqual(test.Length, 15);
        }

    }
}