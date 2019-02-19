using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTests
{
    public class SomeTest
    {
        // takes a string change any text into lowercase then uppercase on repeat, ignoring spaces
        // Hello => hElLo first character should be a lowercase
        public string TextToSpongeBobMeme(string str) {

            return "";
        }

        // takes 3 words, return a string removing the middle word leaving one space
        public string RemoveMiddleWord(string str) {

            return "";
        }

        // takes an array of ints, return the sum of the array NOT INCLUDING THE LARGEST NUMBER
        public int SumIgnoringMax(int[] intArr) {
            
            return -1;
        }

        // takes 2 ints which decides how high the pyramid goes
        /*example for 5, 9

             *
            ***
           *****
          *******
         *********
     
        */
        public char[,] Pyramid(int height, int width) {
            char[,] pyramid = new char[height, width];
            //some code to make it work, good luck 
            
            return pyramid;
        }

        // takes 2 int arrays, returns teh elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2) {

            return new int[] { };
        }

        // Using DateTime and AddDays increment the given date by one year
        public string AddADay(int year, int month, int day)
        {
            return "";
        }
        // An Array of integers are provided theyre in a random order
        // create a method that will sort this array in an acsending order
        public int[] BubSort(int[] unsorted)
        {
            return new int[] { };
        }

        // Create a method that will write the string "Hello" reversed
        public string ReverseString(string str)
        {
            return str;
        }

        //solve 3x^2 + 2x - 1, one of the roots will be the correct answer
        public double Quadratic(int a, int b, int c)
        {
            return 0;
        }

        public int Mult(int num1, int num2)
        {
            return -1;
        }

        public int Test1(int test)
        {
            // create a loop that returns that returns the value of 5 times 29.
            int total = -1;
            return total;
        }

        public DateTime Test2()
        {
            // return the date of Christmas 2015.
            DateTime date = new DateTime(0000, 00, 00);
            return date;
        }

        public char Test3(string test)
        {
            // get 5th letter from the word "Named"
            
            return ' ';
        }

        public int Test4(out int sum)
        {
            // create a loop, return the sum of all the multiples of 4. Also use out the sum of all that is not the multiple of 6.
            int total = 0;
            sum = 0;
            return total;
        }
    }
}
