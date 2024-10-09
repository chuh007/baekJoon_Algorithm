using System.Collections.Generic;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
List<int> maxheap = new List<int>();
            void Input(int input)
            {
                maxheap.Add(input);
                int index = maxheap.Count - 1;
                int dad = (index - 1) / 2;
                while (index > 0 && maxheap[index] > maxheap[dad])
                {
                    int temp = maxheap[index];
                    maxheap[index] = maxheap[dad];
                    maxheap[dad] = temp;
                    index = dad;
                    dad = (index - 1) / 2;
                }
            }
            void Output()
            {
                int max = maxheap[0];
                maxheap[0] = maxheap[maxheap.Count - 1];
                maxheap.RemoveAt(maxheap.Count - 1);
                int index = 0;
                int lastindex = maxheap.Count - 1;
                if (maxheap.Count > 0)
                {
                    while (true)
                    {
                        int leftindex = 2 * index + 1;
                        int rightindex = 2 * index + 2;
                        int largestIndex = index;
                        if (leftindex <= lastindex && maxheap[leftindex] > maxheap[largestIndex])
                        {
                            largestIndex = leftindex;
                        }
                        if (rightindex <= lastindex && maxheap[rightindex] > maxheap[largestIndex])
                        {
                            largestIndex = rightindex;
                        }
                        if (largestIndex == index)
                        {
                            break;
                        }
                        int temp = maxheap[index];
                        maxheap[index] = maxheap[largestIndex];
                        maxheap[largestIndex] = temp;
                        index = largestIndex;
                    }
                }
                sw.WriteLine(max);
            }
            int N = int.Parse(sr.ReadLine());
            for(int i = 0; i < N; i++)
            {
                int input = int.Parse(sr.ReadLine());
                if (input == 0)
                {
                    if (maxheap.Count == 0) sw.WriteLine(0);
                    else Output();
                }
                else Input(input);
            }
            sw.Flush();