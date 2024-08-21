float answer=0;
            float maxScore;
            int testCount = int.Parse(Console.ReadLine());
            float[] testScore = Array.ConvertAll(Console.ReadLine().Split(' '), float.Parse);
            Array.Sort(testScore);
            maxScore = testScore[testScore.Length - 1];
            for (int i = 0; i < testCount; i++)
            {
                testScore[i] = testScore[i]/maxScore*100;
            }
            for (int i = 0; i < testCount; i++)
            {
                answer += testScore[i];
            }
            answer /= testCount;
            Console.WriteLine(answer);