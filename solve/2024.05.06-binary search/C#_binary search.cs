//Microsoft (R) Visual C# Compiler version 3.4.0-beta4-19562-05 (ff930dec)
//Copyright (C) Microsoft Corporation. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            var a = new[]{            -1,0,3,5,9,12};
            Search(a,9);
        }
        
        public static int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length-1;
        while(left<=right){
            int middle = left+((right+left)/2);
            Console.WriteLine($"middle {middle} ,left {left} ,right {right}");

            if(nums[middle]>target){
                Console.WriteLine($"cut right: {right} , middle-1 ->{middle-1}");
                right=middle-1;
            }else if(nums[middle]<target){
                Console.WriteLine($"add left: {left} , middle+1 ->{middle+1}");
                left= middle+1;
            }
            else{
                return middle;
            }
        }
        return -1;
    }
    }
}