using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022__ExMAP_TripDaria_2_
{
    /// <summary>
    /// 114%4 = 0 -> C[1][4] => Problema 19
    /// </summary>
    class Program
    {
        public static int n;
        public static int m;
        public static int[] val = new int[20];

        public static void afisare()
        {
            TextWriter output = new StreamWriter(@"..\..\afisare.txt");
            for (int i = 1; i <= m; i++)
            {
                output.WriteLine(val[i]);
                output.WriteLine(" ");
            }
            output.WriteLine('\n');
        }
        public static void backtracking(int q)
        {
            for (int i = val[q - 1] + 1; i <= n; i++)
            {
                val[q] = i;
                if (q == m)
                {
                    afisare();
                }
                else
                {
                    backtracking(q + 1);
                }
            }
            
        }
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\citire.txt");

            string buffer = load.ReadLine();
            n = int.Parse(buffer.Split(' ')[0]);
            m = int.Parse(buffer.Split(' ')[1]);

            backtracking(1);

            Console.ReadKey();

        }

    }
}
