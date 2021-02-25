using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotationEffecient
{
    class Program
    {
        static int[] RotateArray(int[] Arr,int len, int rotation)
        {
            int[] resarr = new int[len];
            int shift = rotation % len;
            for(int i=0;i<len;i++)
            {
                int temp = i + shift;
                if(temp>len-1)
                {
                    temp = +(temp - len);
                }
                resarr[temp] = Arr[i];
            }
            return resarr;
        }
        static void Main(string[] args)
        {
            int N, K;
            int T = int.Parse(Console.ReadLine());
            while (T!=0)
            {
                string str = Console.ReadLine();
                string[] strarr1 = new string[2];
                strarr1 = str.Split(' ', (char)2);
                N = int.Parse(strarr1[0]); //No of array elements
                K = int.Parse(strarr1[1]); //No of Rotations
                string str2 = Console.ReadLine();
                int[] arr = new int[N];
                arr = Array.ConvertAll(str2.Split(' '), int.Parse);
                int[] result = RotateArray(arr, N, K);
                Console.Write(string.Join(" ", result));
                Console.WriteLine();
                T--;
            }
            Console.ReadKey();
        }
    }
}
