using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = new int[5];
            for(int i = 0; i < input.Length; i++)
            {
                arr[i] = input[i];
            }
            for(int i = input.Length; i < 5; i++)
            {
                arr[i] = 0;
            }
            int answer;
            answer = arr[0] > arr[2] ? (arr[0] - arr[2]) * 508 : (arr[2] - arr[0]) * 108;
            answer += arr[1] > arr[3] ? (arr[1] - arr[3]) * 212 : (arr[3] - arr[1]) * 305;
            answer += arr[4] * 707;
            answer *= 4763;
            sw.Write(answer);
            sw.Flush();