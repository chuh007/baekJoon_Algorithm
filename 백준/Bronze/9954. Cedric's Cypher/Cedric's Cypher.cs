using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string input;
            while ((input = sr.ReadLine()) != null)
            {
                int rotate = input[input.Length - 1] - 'A';
                for(int i = 0; i < input.Length - 1; i++)
                {
                    if ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z'))
                    {
                        if (input[i] <= 'Z')
                        {
                            if (input[i] - 'A' - rotate >= 0) sw.Write((char)((input[i] - 'A' - rotate) % 26 + 'A'));
                            else sw.Write((char)((input[i] - 'A' - rotate + 26) % 26 + 'A'));
                        }
                        else
                        {
                            if (input[i] - 'a' - rotate >= 0) sw.Write((char)((input[i] - 'a' - rotate) % 26 + 'a'));
                            else sw.Write((char)((input[i] - 'a' - rotate + 26) % 26 + 'a'));
                        }
                    }
                    else sw.Write(input[i]);
                }
                sw.Write('\n');
                sw.Flush();
            }