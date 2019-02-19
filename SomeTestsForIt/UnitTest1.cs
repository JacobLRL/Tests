using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeTests;

namespace SomeTestsForIt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Spongebob()
        {
            var Tests = new SomeTests.SomeTest();
            Assert.AreEqual("hElLo", Tests.TextToSpongeBobMeme("Hello"));
            Assert.AreEqual("jQuErY iS bEtTeR", Tests.TextToSpongeBobMeme("jQuery is better"));
            Assert.AreEqual("", Tests.TextToSpongeBobMeme(""));
            
        }

        [TestMethod]
        public void Check_Remove_Middle_Word()
        {
            var Tests = new SomeTests.SomeTest();
            Assert.AreEqual("sup dude", Tests.RemoveMiddleWord("sup my dude"));
            Assert.AreEqual("yeet yeet", Tests.RemoveMiddleWord("yeet yeet yeet"));
        }

        [TestMethod]
        public void Check_Sum_Of_Array()
        {
            var Tests = new SomeTests.SomeTest();
            Assert.AreEqual(9, Tests.SumIgnoringMax(new int []{ 2, 3, 4, 5 }));
            Assert.AreEqual(1005, Tests.SumIgnoringMax(new int[] { 999, 1000, 5, 1 }));
            Assert.AreEqual(9, Tests.SumIgnoringMax(new int[] { 1,2,1,1,1,1,1,1,1,1 }));
        }

        [TestMethod]
        public void Check_Pyramid()
        {
            var Tests = new SomeTests.SomeTest();
            CollectionAssert.AreEqual( new char[,] { 
                { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
                { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
                { ' ', '*', '*', '*', '*', '*', '*', '*', ' ' },
                { '*', '*', '*', '*', '*', '*', '*', '*', '*' }
            }, Tests.Pyramid(5,9));
            CollectionAssert.AreEqual(new char[,] {
                { ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', '*', '*', '*', '*', '*', '*', '*', ' ', ' ', ' ' },
                { ' ', ' ', '*', '*', '*', '*', '*', '*', '*', '*', '*', ' ', ' ' },
                { ' ', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', ' ' },
                { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*' }
            }, Tests.Pyramid(7, 13));
        }
        [TestMethod]
        public void Check_Different()
        {
            var Tests = new SomeTests.SomeTest();
            Assert.AreEqual(new int[] { 1, 3, 4, 5 }, Tests.Different(new int[] { 1,2,3,4,5 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { }, Tests.Different(new int[] { }, new int[] { 2, 3, 4 }));
            Assert.AreEqual(new int[] { 2, 3, 4 }, Tests.Different(new int[] { 2, 3, 4 }, new int[] { }));
        }

        [TestMethod]
        public void AddYearToDateTest()
        {
            // arrange (setup)
            var arrayInstance = new SomeTests.SomeTest();
            var expectedOutput = "01/01/2020 00:00:00";
            // act (run code)
            var actualOutput = arrayInstance.AddADay(2019, 1, 1);
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void BuubleSortTest()
        {
            // arrange (setup)
            var Instance = new SomeTests.SomeTest();
            int[] expectedOutput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] unsorted = { 4, 2, 8, 3, 9, 10, 5, 6, 1, 7 };
            // act (run code)
            var actualOutput = Instance.BubSort(unsorted);
            // assert (see if test pass/fail)
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            // arrange (setup)
            var Instance = new SomeTests.SomeTest();
            string expectedOutput = "olleH";
            // act (run code)
            var actualOutput = Instance.ReverseString("Hello");
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void QuadraticTest()
        {
            // arrange (setup)
            var Instance = new SomeTests.SomeTest();
            int expectedOutput = -1;
            // act (run code)
            var actualOutput = Instance.Quadratic(3, 2, -1);
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

       
        [TestMethod]
        public void TestMethod()
        {
            //Arrange 
            int expected = 50;
            int num1 = 10;
            int num2 = 5;
            var Instance = new SomeTests.SomeTest();
            //Act
            int actual = Instance.Mult(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            // arrange (setup)
            var unit = new SomeTests.SomeTest();
            var expectedOutput = 145;
            // act (run code)
            var actualOutput = unit.Test1(10);
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange (setup)
            var unit = new SomeTests.SomeTest();
            var expectedOutput = "25/12/2015";
            // act (run code)
            var actualOutput = unit.Test2();
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput.ToShortDateString());
        }
        [TestMethod]
        public void TestMethod3()
        {
            // arrange (setup)
            var unit = new SomeTests.SomeTest();
            var expectedOutput = 'd';
            // act (run code)
            var actualOutput = unit.Test3("Named");
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // arrange (setup)
            var unit = new SomeTests.SomeTest();
            var expectedOutput = 5534;
            // act (run code)
            var actualOutput = unit.Test4(out int sum) + sum;
            // assert (see if test pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
