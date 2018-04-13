﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                int[] result = icecreamParlor(m, arr);
                Console.WriteLine(String.Join(" ", result));


            }
        }

        static int[] icecreamParlor(int m, int[] arr)
        {
            int[] indexes = new int[2];
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == m)
                    {
                        indexes[0] = i + 1;
                        indexes[1] = j + 1;
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }

            return indexes;
        }
    }
}
