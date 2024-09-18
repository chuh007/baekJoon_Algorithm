using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new StringBuilder();

int N, m, M, T, R;
int answer = 0;
int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
N = input[0];
m = input[1];
M = input[2];
T = input[3];
R = input[4];
int nowTime = 0;
int nowm = m;

while (nowTime != N)
{
    if (m + T > M)
    {
        answer = -1;
        break;
    }

    if (nowm + T <= M)
    {
        nowm += T;
        nowTime++;
    }
    else
    {
        nowm -= R;
        if (nowm < m)
        {
            nowm = m;
        }
    }
    answer++;
}

sw.Write(answer);
sw.Flush();