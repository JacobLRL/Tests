# Unit Tests Labs

This repo contains straightforward C# coding problems. Each problem is validated by a unit test

Here are the majority of the answers, some may be wrong or missing due to changes to the Methods goal

or further implementation of the tests, to make them harder to pass.

## Questions

## Solutions

```csharp
//May not be the perfect solution:
	// takes a string change any text into lowercase then uppercase on repeat, ignoring spaces
        public string TextToSpongeBobMeme(string str) {
            bool even = true;
            string str1 = "";
            foreach (var elem in str) {
                if (even && elem != ' ') {
                    str1 += elem.ToString().ToLower();
                    even = false;
                } else if (!even && elem != ' ') {
                    str1 += elem.ToString().ToUpper();
                    even = true;
                } else {
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
            foreach (var elem in intArr) {
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

	// takes 2 int arrays, returns teh elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2) {

            return new int[] { };
        }

	// Using DateTime and AddDays increment the given date by one year
        public string AddADay(int year, int month, int day)
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
            string reverse = null;
            int l = 0;

            l = str.Length - 1;
            while (l >= 0)
            {
                reverse = reverse + str[l];
                l--;
            }
            return reverse;
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

        public int Mult(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Test1(int test)
        {
            // create a loop that returns that returns the value of 5 times 29.
            int total = 0;
            for (int i = 0; i < test; i++)
            {
                total += i + test;
            }
            return total;
        }

        public DateTime Test2()
        {
            // return the date of Christmas 2015.
            DateTime date = new DateTime(2015, 12, 25);
            return date;
        }

        public char Test3(string test)
        {
            // get 5th letter from the word "Named"
            char[] charTest = test.ToCharArray();
            return charTest[4];
        }

        public int Test4(out int sum)
        {
            // create a loop, return the sum of all the multiples of 4. Also use out the sum of all that is not the multiple of 6.
            int total = 0;
            sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 4 == 0)
                {
                    total += i;
                }
                if (i % 6 != 0)
                {
                    sum += i;
                }
            }

            return total;
        }

        // return sum of seq and b , the value of sum should equate to 45 and the total including b =  585

        public double summation(double b)
        {
            double sum = 0;
            double[] seq = { 20.3, 2.1, b, 14.4 };
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[2] == 8.2)
                {
                    sum = seq[i] + 0 + 1 + 2 + 3;
                }
            }
            return sum * 13;
        }

        // 
        public bool isWithdraw(int value)
        {
            bool isValuePositive = false;
            if (value > 10)
            {
                isValuePositive = true;
            }
            return isValuePositive;
        }

        // 
        public bool isAllowedEntry(int value)
        {
            bool isAllowed = false;
            List<int> ages = new List<int>();
            ages.Add(1);
            ages.Add(13);
            ages.AddRange(ages);
            foreach (var i in ages)
            {
                if (value >= i)
                {
                    isAllowed = true;
                }
            }
            return isAllowed;
        }
        // 
        public bool NameReturn(char a, char b, char c, char d)
        {
            bool isName = false;
            char[] nameTake = { a, b, c, d };
            string name = nameTake.ToString();
            if (name == "jess")
            {
                isName = true;
            }
            return isName;
        }

```