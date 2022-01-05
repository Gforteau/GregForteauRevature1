﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_ArraysAndListsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }//EoM

        /// <summary>
        /// This method takes an array of integers and returns a double, the average 
        /// value of all the integers in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double AverageOfValues(int[] array)
        {
            double sum = 0;
            double average;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return average = sum / array.Length;
        }

        /// <summary>
        /// This method increases each array element by 2 and 
        /// returns an array with the altered values.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] SunIsShining(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            }
            return x;
        }

        /// <summary>
        /// This method takes an ArrayList containing types of double, int, and string 
        /// and returns the average of the ints and doubles only, as a decimal.
        /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
        /// </summary>
        /// <param name="myArrayList"></param>
        /// <returns></returns>
        public static decimal ArrayListAvg(ArrayList myArrayList)
        {
            decimal x = 0;
            int count = 0; // needs a counter because if it returns a type of string, then you must have a new count that exlucdes the strings for the average
            for (int i = 0; i < myArrayList.Count; i++)
            {
                if (myArrayList[i].GetType() != typeof(String)) // checks to see if the index position being evaluated if is not the type of string
                {
                    x += Convert.ToDecimal(myArrayList[i]); // converts the number that passes for if condition to a decimal
                    count++;
                }
            }
            return Math.Round(x / count, 3); // rounds to the 3rd decimal position
        }// help

        /// <summary>
        /// This method returns the rank (starting with 1st place) of a new 
        /// score entered into a list of randomly ordered scores.
        /// </summary>
        /// <param name="myArray1"></param>
        public static int ListAscendingOrder(List<int> scores, int yourScore)
        {
            int rank = 0;
            scores.Add(yourScore);
            scores.Sort();
            rank = scores.IndexOf(yourScore);
            return ++rank;
        }// help

        /// <summary>
        /// This method has with two parameters takes a List<string> and a string.
        /// The method returns true if the string parameter is found in the List, otherwise false.
        /// </summary>
        /// <param name="myArray2"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool FindStringInList(List<string> myArray2, string word)
        {
            if (myArray2.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }//EoP
}