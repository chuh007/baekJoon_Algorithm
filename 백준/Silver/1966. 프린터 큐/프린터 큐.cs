using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Queue<(int, int)> queue = new Queue<(int, int)>();
                for(int j = 0; j < input[0]; j++)
                {
                    queue.Enqueue((arr[j], j));
                }
                int count = 0;
                while (true)
                {
                    if (queue.Peek().Item1 == queue.Max().Item1)
                    {
                        count++;
                        if (queue.Peek().Item2 == input[1]) break;
                        queue.Dequeue();
                    }
                    else
                    {
                        (int, int) item = queue.Dequeue();
                        queue.Enqueue(item);
                    }
                }
                sw.WriteLine(count);
            }
            sw.Flush();