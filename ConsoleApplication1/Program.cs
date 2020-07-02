using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            int daysUntilFriday = ((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextFriday = today.AddDays(daysUntilFriday);

           
                // This  declares an integer array with 5 elements
                int[] test2 = new int[5];

                List<int> listNumbers = new List<int>();
                Random randNum = new Random();
                for (int i = 0; i < test2.Length; i++)
                {
                    test2 = Enumerable.Range(1, 50).OrderBy(x => randNum.NextDouble()).Take(5).ToArray();
                }
                //Array.ForEach(test2, Console.WriteLine);

                int[] a = test2;
                int t;

                for (int i = 0; i < a.Length; i++)
                {
                    //Console.WriteLine(a[i]);
                }
                for (int j = 0; j <= a.Length - 2; j++)
                {
                    for (int i = 0; i <= a.Length - 2; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            t = a[i + 1];
                            a[i + 1] = a[i];
                            a[i] = t;
                        }
                    }
                }

                // this declares an integer array with 2 elements
                int[] test3 = new int[2];

                Random randNum3 = new Random();
                for (int i = 0; i < test3.Length; i++)
                {
                    test3 = Enumerable.Range(1, 10).OrderBy(x => randNum3.NextDouble()).Take(2).ToArray();
                }
                //Array.ForEach(test3, Console.WriteLine(string.Join);

                int[] b = test3;
                int u;

                for (int i = 0; i < b.Length; i++)
                {
                    // Console.Write("  " + b[i]  + " ");
                }
                for (int j = 0; j <= b.Length - 2; j++)
                {
                    for (int i = 0; i <= b.Length - 2; i++)
                    {
                        if (b[i] > b[i + 1])
                        {
                            u = b[i + 1];
                            b[i + 1] = b[i];
                            b[i] = u;
                        }
                    }
                }

                FileInfo fi = new FileInfo("C:\\Users\\marco zani\\Desktop\\log.txt");
                using (TextWriter txtWriter = new StreamWriter(fi.Open(FileMode.Truncate))) ;

                Console.WriteLine("  " + nextFriday);
                Console.WriteLine(Environment.NewLine);
                foreach (int aray in a)
                    Console.Write("  " + aray + " ");
                Console.WriteLine(Environment.NewLine);
                foreach (int arad in b)
                    Console.Write("  " + arad + " ");

                var write = $"{String.Join(" ", a.Select(x => x.ToString()))}";
                var star = $"{String.Join(" ", b.Select(x => x.ToString()))}";
                
                //Output the results
                File.AppendAllText("C:\\Users\\marco zani\\Desktop\\log.txt", write + "     " + star + Environment.NewLine);

                Console.ReadLine();
            

        }
    }
}


