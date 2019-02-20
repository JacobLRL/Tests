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

        // takes 2 int arrays, returns the elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2) {

            return new int[] { };
        }

        // Using DateTime and AddDays increment the given date by one year
        public string AddAYear(int year, int month, int day)
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
        // given 2 numbers, return the product of the 2
        public int Mult(int num1, int num2)
        {
            return -1;
        }
        // create a loop that returns the value of 5 times the inputted number.
        public int ProductFive(int test)
        {
            return -1;
        }
        // get 5th letter from the words inputted not including spaces
        //if there aren't 5 letters return a whitespace char ' '
        public char FifthLetter(string test)
        {
            return ' ';
        }
        // create a loop, return the sum of all the multiples of 4. Also use out the sum of all that is not the multiple of 6.
        // return the sum of all of the multiples of 4, which aren't multiples of 6, up to the inputted number,
        public int SumOfFours(int test)
        {
            return -1;
        }

        // return sum of seq and b , the value of sum should equate to 45 and the total including b =  585
        public double Summation(double b)
        {
            double sum = 0;
            double[] seq = { 20.3, 2.1, b, 14.4 };
            return sum;
        }

        // return true if the value is positive, else return false
        public bool Withdraw(int value)
        {
            bool isValuePositive = false;
            return isValuePositive;
        }

        // not sure what this is supposed to do !!!!!!!!!!!!!!!
        public bool AllowedEntry(int value)
        {
            bool isAllowed = false;
            List<int> ages = new List<int>();
            
            return isAllowed;
        }
        // return true is the 4 characters make up a string that match a name in the array given
        public bool NameReturn(char a, char b, char c, char d)
        {
            bool isName = false;
            string[] names = new string[] { "chad", "jess", "adam" };
            
            return isName;
        }

        //reverse the string that is inputted
        public string Reverse(string word)
        {
            // Code here
            return "";
        }
        // Find the smallest integer in an array of integers
        public int Smallest(int[] intArray)
        {
            //Code here
            return -1;
        }

        // given a positive integer that is a squared number
        // find the next squared number eg 9 => 16
        public int NextSquare(int n)
        {
            // Code here
            return -1;
        }
        // Calculate the nth term in a geometric series , a_n
        // a_1 is the first term, r is the common ratio and n is the number of terms
        // Remember the first term a_1 is already given, that is, n = 1
        // Give your answer to 2d.p.
        public double GeometricSeries(int a_1, double r, int n)
        {
            // Code here
            return -1;
        }

        public int CreateArray(int size)
        {
            int[] myArray = new int[size];
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = (i + 1) * (i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }


        public int StackTest()
        {
            Stack<int> stack1 = new Stack<int>();
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                stack1.Push(i * i * i);
            }

            for (int j = 0; j < 10; j++)
            {
                sum += stack1.Pop();
            }
            return sum;
        }
        public int QueueTest()
        {
            Queue<int> queue1 = new Queue<int>();
            int sum1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                queue1.Enqueue(i * i * i);
            }

            for (int j = 0; j < 10; j++)
            {
                sum1 += queue1.Dequeue();
            }
            return sum1;
        }
    }
}
