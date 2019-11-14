using System;

namespace _07__Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Lesson 1
            //int[] grades = new int[5];

            //grades[0] = 20;
            //grades[1] = 15;
            //grades[2] = 12;
            //grades[3] = 9;
            //grades[4] = 7;

            //Console.WriteLine("grades at index 0 : {0}", grades[0]);
            ////assign value to array grades at index 0 
            //string input = Console.ReadLine();

            //grades[0] = int.Parse(input);


            //Console.WriteLine("grades at index 0 : {0}", grades[0]);

            //int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //int[] gradesOfMathStudentsB = { 15, 20, 3, 17, 18, 15 };

            //Console.WriteLine("Length of gradesOfMathStudentsA: {0}",gradesOfMathStudentsA.Length);


            //Lesson 2
            //int[] nums = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i + 10;
            //}

            //for (int j = 0; j < nums.Length; j++)
            //{
            //    Console.WriteLine("Element{0} = {1}", j, nums[j]);
            //}
            //int counter = 0;
            //foreach (int k in nums)
            //{
            //    Console.WriteLine("Element{0} = {1}", counter, k);
            //    counter++;
            //}
            /*******************************************************************************/

            //Challenge: Create an array with 5 of your best friends
            //Create a foreach loop which greets all of them


            //string[] friends = { "Robert", "Kolten", "Bobby", "Chris", "Ariel"};

            //int myCounter = 0;

            //foreach (string myFriend in friends)
            //{
            //    Console.WriteLine("Hello {0}", myFriend );
            //    myCounter++;
            //}

            //Lesson 3

            //Declare a 2D array
            string[,] matrix;

            //Declare a 3D array
            int[,,] threeD;

            //Two demensional array 
            int[,] array2D = {
                {1,2,3},// row 0
                {4,5,6},// row 1
                {7,8,9} // row 2
            };



            Console.WriteLine("Central value is {0}", array2D[2,0]);

            //Initialize new 3D array
            string[,,] array3D =
            { //First dimesion
                {       //Second dimesion
                    {"000", "001"},     //Third dimesion 
                    {"010", "011" },
                    {"Hi there!", "What's up?" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry"}

                }
            };

            //print value
            Console.WriteLine("The value is {0}", array3D[0,2,0]);

            //Specify number of entries
            string[,] array2DString = new string[3, 2]
            {
                { "one", "two"}, 
                { "three", "four"},
                { "five", "six"},
            };

            array2DString[1, 1] = "chicken";//Change value "four"

            Console.WriteLine("The at [1,1] is: {0}", array2DString[1,1]);

            //find dimension of array
            int dimension = array2DString.Rank;

            Console.WriteLine("The value is {0}", dimension);

        }
    }
}
