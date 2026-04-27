string[] nonAns = { "i", "pa", "te", "ni", "niti", "a", "ali", "nego", "no", "ili" };
            string[] s = Console.ReadLine().Split(' ');
            string answer = "";
            answer += s[0][0];
            for (int i = 1; i < s.Length; i++)
            {
                bool iscanAns = true;
                for (int j = 0; j < nonAns.Length; j++)
                {
                    if (s[i] == nonAns[j])
                    {
                        iscanAns = false;
                        break;
                    }
                }
                if (iscanAns)
                {
                    answer += s[i][0];
                }
            }
            Console.WriteLine(answer.ToUpper());