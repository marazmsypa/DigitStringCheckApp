using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCheckLibrary;

namespace StringCheckLibraryTests
{
    [TestClass]
    public class StringCheckTests
    {
        StringCheck testedObj = new StringCheck();
        /// <summary>
        /// тест на неповторяющиеся цифры
        /// </summary>
        [TestMethod]
        public void GetDigit_NormalString_ListResult()
        {
            //Arrange
            string entryString = "123456789";
            List<char> expectList = new List<char> { '9', '8', '7', '6' };
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }
        /// <summary>
        /// тест на наличие в строке букв
        /// </summary>
        [TestMethod]
        public void GetDigit_StringWithLetters_ListResult()
        {
            //Arrange
            string entryString = "123456789привет";
            List<char> expectList = new List<char> { '9', '8', '7', '6' };
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }

        /// <summary>
        /// тест на наличие в строке посторонних символов
        /// </summary>
        [TestMethod]
        public void GetDigit_StringWithSymbols_ListResult()
        {
            //Arrange
            string entryString = "1,2,3,4,5,6,7,8,9!";
            List<char> expectList = new List<char> { '9', '8', '7', '6' };
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }
        /// <summary>
        /// тест на наличие в строке пробелов
        /// </summary>
        [TestMethod]
        public void GetDigit_StringWithSpace_ListResult()
        {
            //Arrange
            string entryString = "1 2 3 4 5 6 7 8 9";
            List<char> expectList = new List<char> { '9', '8', '7', '6' };
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }

        /// <summary>
        /// тест на повторяющиеся цифры
        /// </summary>
        [TestMethod]
        public void GetDigit_StringWithRepeat_ListResult()
        {
            //Arrange
            string entryString = "123456789123456789";
            List<char> expectList = new List<char> { '9', '8', '7', '6' };
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }

        /// <summary>
        /// тест на пустую строку
        /// </summary>
        [TestMethod]
        public void GetDigit_EmtyString_ListResult()
        {
            //Arrange
            string entryString = "";
            List<char> expectList = new List<char>();
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }

        /// <summary>
        /// тест на цифры только меньшие шести
        /// </summary>
        [TestMethod]
        public void GetDigit_LessThanSixDigit_ListResult()
        {
            //Arrange
            string entryString = "12345";
            List<char> expectList = new List<char>();
            //Act
            List<char> actualList = testedObj.GetDigit(entryString);
            //Assert
            CollectionAssert.AreEqual(actualList, expectList);
        }
    }
}
