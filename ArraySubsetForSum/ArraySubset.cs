using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySubsetForSum
{
    public static class ArraySubset
    {
        public static void FindRequiredSumSubArray(int[] arr, int sum)
        {
            //create an array for the subset with max length of input array  
            int[] sub = new int[arr.Length];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i, col = 0; j < arr.Length; j++, col++)
                {
                    //add the value of input array one by one  
                    temp += arr[j];
                    sub[col] = arr[j];
                    //if addition is equal to sum then print it  
                    if (temp == sum)
                    {
                        int total = 0;
                        for (int k = 0; k < sub.Length; k++)
                        {
                            total += sub[k];
                            Console.Write(sub[k].ToString() + " ");

                            //if total and sum are equal then leave the print  
                            if (total == sum)
                            {
                                Console.Write("\n");
                                break;
                            }
                        }
                    }
                    //if temp is greater than sum are equal then clear the sub array, set temp value and leave the loop for next  
                    if (temp > sum)
                    {
                        Array.Clear(sub, 0, sub.Length);
                        temp = 0;
                        break;
                    }
                }
            }
        }
    }
}
