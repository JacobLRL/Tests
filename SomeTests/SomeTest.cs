﻿using System;
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
    }
}
