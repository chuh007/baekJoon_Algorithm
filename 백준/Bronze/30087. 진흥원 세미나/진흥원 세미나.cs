using System.Linq;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                switch (s)
                {
                    case "Algorithm":
                        sw.WriteLine("204");
                        break;
                    case "DataAnalysis":
                        sw.WriteLine("207");
                        break;
                    case "ArtificialIntelligence":
                        sw.WriteLine("302");
                        break;
                    case "CyberSecurity":
                        sw.WriteLine("B101");
                        break;
                    case "Network":
                        sw.WriteLine("303");
                        break;
                    case "Startup":
                        sw.WriteLine("501");
                        break;
                    case "TestStrategy":
                        sw.WriteLine("105");
                        break;
                }
            }
            sw.Flush();
