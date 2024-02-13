using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        //arrays / variables



        static void Main(string[] args)
        {
          

            int[,] my2DArray = new int[3, 4] { { 3, 3, 3, 4 }, { 1, 3, 1, 3 }, { 2, 2, 2, 2 } };
            //functions 2
            //returns list

            List<int> newlist = FuncTwo(my2DArray);
            for (int i = 0; i < newlist.Count; i++)
            {
                Console.WriteLine(newlist[i]);
            }

            // myList.Add("object to add")   ... adds data to end of the list
            // myList.Insert(2, "object to add").
            Console.WriteLine("The amount of 3's in newlist is " + newlist.Count);
        }



        public static void FuncOne(List<Double> myStudentList)
        {
            double sum = 0;
            for (int i = 0; i < myStudentList.Count; i++)
            {
                sum += myStudentList[i];
            }
            double average = (sum / myStudentList.Count);
            Console.WriteLine("the average of the list of doubles is " + (average));

            for (int i = 0; i < myStudentList.Count; i++)
            {
                myStudentList[i] -= average;
                Console.WriteLine("The result of the entry minus the average value is: " + myStudentList[i]);
            }
        }
        public static List<int> FuncTwo(int[,] my2DArray)
        {
            List<int> myIntList = new List<int>();

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    // Console.Write(my2DArray[i, j] + "\t");

                    if (my2DArray[i, j] % 3 == 0)
                    {
                        myIntList.Add(my2DArray[i, j]);
                    }
                }
            }

            return myIntList;

        }


    }

}


/* List<Double> myStudentList = new List<Double>();         EX 7

          Random randomValue = new Random();
          int randomNumber = randomValue.Next(4, 8);

          Console.WriteLine("You now need to add " + randomNumber + " values to your list of Doubles");
          for (int i = 0; i < randomNumber; i++)
          {
              Console.WriteLine("Please enter the value of entry " + (i + 1) + ": ");
              myStudentList.Add(Convert.ToDouble(Console.ReadLine()));
              Console.WriteLine();
          }

          //functions 1
          FuncOne(myStudentList); */

/*   EX 6
List<String> myStudentList = new List<string>();

Random randomValue = new Random();
int randomNumber = randomValue.Next(1, 12);

Console.WriteLine("You now need to add " + randomNumber + " students to your class list");
for (int i = 0; i < randomNumber; i++)
{
    Console.WriteLine("Please enter the name of the Student " + (i + 1) + ": ");
    myStudentList.Add(Console.ReadLine());
    Console.WriteLine();
} */



// EX.5
/* int[,] myArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
        Console.Write(myArray[i, j] + "\t");
}
Console.WriteLine(); */

/*  double[] doubleArray = new double[10];     // EX. 5

            int currentSize = 0;

            double currentLargest, currentSmallest;

            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine("Hello, Enter your the numbers.");
                doubleArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            currentLargest = doubleArray[0];
            currentSmallest = doubleArray[0];

            for (int i = 0; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > currentLargest)
                {
                    currentLargest = doubleArray[i];
                    Console.WriteLine("The Number at index " + i + " in the array is " + doubleArray[i]);
                }
                else if (doubleArray[i] < currentSmallest)
                {
                    currentSmallest = doubleArray[i];
                    Console.WriteLine("The Number at index " + i + " in the array is " + doubleArray[i]);
                }
                else
                {
                    Console.WriteLine("The Number at index " + i + " in the array is " + doubleArray[i]);

                }
                
            }

            Console.WriteLine("The biggest number in the Array is: " + currentLargest);
            Console.WriteLine("The smallest number in the Array is: " + currentSmallest); */


/* string[] studentNames = new string[6];           // EX. 4
    for(int i = 0; i < studentNames.Length; i++)
    {
        Console.WriteLine("Hello, Enter your name please?.");
        studentNames[i] = Console.ReadLine();
    }
    for (int i = 0; i < studentNames.Length; i++)
    {
        Console.WriteLine("The Name at index " + i + " in the array is " + studentNames[i]);
    } */


//////////////////////////////////??/////////??????///////
/* int[] studentArray = {87, 68, 94,100, 83, 78, 85, 91, 76, 87}; //ex 3

     int total = 0;

     for (int i = 0; i < studentArray.Length; i++)        //studentarray!
     {
         total += studentArray[i];
     }

     Console.WriteLine("The total marks for the student is: " + total);
     Console.WriteLine("This consist of " + studentArray.Length + " marks.");
     Console.WriteLine("Therefore the average mark is " + (total/studentArray.Length));




 //int array     //ex2
 int[] myArray2 = new int[10]; 
 for (int i = 0; i < 10; i++)    //forloop for populating array
 {
     myArray2[i] = i;
 } 
 for (int i = 0; i < 10; i++)
 {
     Console.WriteLine("The element at position " + i + " in the array is " + myArray2[i]);
 }

 //double array. //ex 1
 double[] myArray = new double[10];
 myArray[0] = 1.0;
 myArray[1] = 1.1;
 myArray[2] = 1.2;
 myArray[3] = 1.3;
 myArray[4] = 1.4;
 myArray[5] = 1.5;
 myArray[6] = 1.6;
 myArray[7] = 1.7;
 myArray[8] = 1.8;
 myArray[9] = 1.9;

 //index 0 is the first place. double array ex1
 Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
 Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
 Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
 Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
 Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
 Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
 Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
 Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
 Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
 Console.WriteLine("The element at index 9 in the array is " + myArray[9]); */




