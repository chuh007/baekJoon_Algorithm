using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                        31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                        73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                        127, 131, 137, 139, 149, 151, 157, 163, 167, 173,
                        179, 181, 191, 193, 197, 199};
            int a = int.Parse(sr.ReadLine());
            int ans = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                ans = arr[i] * arr[i - 1];
                if (a < ans) break;
            }
            sw.Write(ans);
            sw.Flush();