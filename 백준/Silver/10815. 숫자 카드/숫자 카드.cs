using System.Linq;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int N = int.Parse(sr.ReadLine());
            int[] arr1 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Array.Sort(arr1);
            int M = int.Parse(sr.ReadLine());
            int[] arr2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for (int i = 0; i < arr2.Length; i++)
            {
                int low = 0;
                int high = arr1.Length - 1;
                bool isEnd = false;
                int count = 0;
                int findNum = arr2[i];
                while (!isEnd && low <= high)
                {
                    int middle = (low + high) / 2;
                    if (arr1[middle] == findNum)
                    {
                        count++;
                        isEnd = true;
                    }
                    else if (arr1[middle] > findNum) high = middle - 1;
                    else if (arr1[middle] < findNum) low = middle + 1;
                }
                sw.Write(count + " ");
            }
            sw.Flush();