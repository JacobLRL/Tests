using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SomeTests
{
    public class SomeTest
    {
        // takes a string change any text into lowercase then uppercase on repeat, ignoring spaces
        // Hello => hElLo first character should be a lowercase
        public string TextToSpongeBobMeme(string str) {
            bool even = true;
            string str1 = "";
            foreach (var elem in str)
            {
                if (even && elem != ' ')
                {
                    str1 += elem.ToString().ToLower();
                    even = false;
                }
                else if (!even && elem != ' ')
                {
                    str1 += elem.ToString().ToUpper();
                    even = true;
                }
                else
                {
                    str1 += elem;
                }
            }
            return str1;
        }

        // takes 3 words, return a string removing the middle word leaving one space
        public string RemoveMiddleWord(string str) {
            string[] str1 = str.Split(' ');
            return str1[0] + " " + str1[2];
        }

        // takes an array of ints, return the sum of the array NOT INCLUDING THE LARGEST NUMBER
        public int SumIgnoringMax(int[] intArr) {
            int max = 0;
            int sum = 0;
            foreach (var elem in intArr)
            {
                if (elem > max) max = elem;
                sum += elem;
            }
            return sum - max;
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
            bool b = false;
            int count = 0;
            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                for (int j = 0; j < pyramid.GetLength(1); j++)
                {
                    if ((pyramid.GetLength(1) / 2 - i) == j || b)
                    {
                        b = true;
                        pyramid[i, j] = '*';
                        count++;
                        if (count == 2 * i + 1)
                        {
                            b = false;
                            count = 0;
                        }
                    }
                    else
                    {
                        pyramid[i, j] = ' ';
                    }
                }
            }
            return pyramid;
        }

        // takes 2 int arrays, returns the elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2) {
            List<int> ans = new List<int>();
            foreach (var elem in arr1) {
                if (!arr2.Contains(elem)) {
                    ans.Add(elem);
                }
            }
            return ans.ToArray();
        }

        // Using DateTime and AddDays increment the given date by one year
        public string AddAYear(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            date = date.AddDays(365);
            string test1 = date.ToString();
            return test1;
        }
        // An Array of integers are provided theyre in a random order
        // create a method that will sort this array in an acsending order
        public int[] BubSort(int[] unsorted)
        {
            int temp = 0;
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = 0; j < unsorted.Length - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        temp = unsorted[j + 1];
                        unsorted[j + 1] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }
            return unsorted;
        }

        // Create a method that will write the string "Hello" reversed
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //solve 3x^2 + 2x - 1, one of the roots will be the correct answer
        public double Quadratic(int a, int b, int c)
        {
            double d = 0;
            double x1 = 0;
            double x2 = 0;

            d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            return x2;
        }
        
        // get 5th letter from the words inputted not including spaces
        //if there aren't 5 letters return a whitespace char ' '
        public char FifthLetter(string test)
        {
            // regex is regular expression for people who don't know
            string ans = Regex.Replace(test, @"\s+", "");
            if (ans.Length < 5) return ' ';
            return ans[4];
        }
        // create a loop, return the sum of all the multiples of 4. Also use out the sum of all that is not the multiple of 6.
        // return the sum of all of the multiples of 4, which aren't multiples of 6, up to the inputted number,
        public int SumOfFours(int test)
        {
            int sum = 0;
            for (int i = 1; i <= test; i++) {
                if (i%4 == 0 && i % 6 != 0) sum += i;
            }
            return sum;
        }

        // return true is the 4 characters make up a string that match a name in the array given
        public bool NameReturn(char a, char b, char c, char d)
        {
            string[] names = new string[] { "chad", "jess", "adam" };
            string name = ""+a+b+c+d;
            return names.Contains(name);
        }

        // Find the smallest integer in an array of integers
        public int Smallest(int[] intArray)
        {
            return intArray.Min();
        }

        // given a positive integer that is a squared number
        // find the next squared number eg 9 => 16
        public int NextSquare(int n)
        {
            // Code here
            return (int) Math.Pow(Math.Sqrt(n)+1, 2);
        }
        // Calculate the nth term in a geometric series , a_n
        // a_1 is the first term, r is the common ratio and n is the number of terms
        // Remember the first term a_1 is already given, that is, n = 1
        // Give your answer to 2d.p.
        public double GeometricSeries(int a1, double r, int n)
        {
            // Code here
            double d = a1;
            for (int i = 0; i < n - 1; i++)
            {
                d = d * r;
            }
            return Math.Round(d, 2);
        }
    }
}
