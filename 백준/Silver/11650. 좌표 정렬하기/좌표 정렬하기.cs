using System.Text;
using System.IO;
StreamReader strRead = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter strWrite = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder strBild = new StringBuilder();
            List<(int, int)> listIS = new List<(int, int)>(); // int,int를 가지는 T 리스트 만들기
            int a = int.Parse(strRead.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int[] s = Array.ConvertAll(strRead.ReadLine().Split(' '),int.Parse); // 정수 변환
                listIS.Add((s[0], s[1]));
            }
            var sort = listIS.OrderBy(x => x.Item1).ThenBy(x=>x.Item2);
            foreach (var wow in sort)
            {
                strBild.AppendLine($"{wow.Item1} {wow.Item2}");
            }
            strWrite.Write(strBild);
            strWrite.Flush();