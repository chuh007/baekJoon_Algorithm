using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            string s, temp = "";
            int sum = 0;
            bool isAfrica = false;
            for(int i = 0; i < a; i++)
            {
                s = sr.ReadLine();
                if(s == "south-africa")
                {
                    isAfrica = true;
                }
                else if(s == "kenya" || s == "tanzania" || s == "ethiopia") 
                {
                    sum += 50;
                }
                else if(s == "namibia")
                {
                    if (isAfrica) sum += 40;
                    else sum += 140;
                }
                else if(s == "zambia" || s == "zimbabwe")
                {
                    if (s == "zambia") sum += 50;
                    else sum += 30;
                    if (temp == "zambia" || temp == "zimbabwe") sum -= 30;
                }
                temp = s;
            }
            sw.Write(sum);
            sw.Flush();