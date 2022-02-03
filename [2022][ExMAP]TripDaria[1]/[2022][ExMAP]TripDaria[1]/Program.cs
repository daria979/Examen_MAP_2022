using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022__ExMAP_TripDaria_1_
{
    class Program
    {
        /// <summary>
        /// 84%4 = 0 => C[0][0] => Problema 1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n, m;
            int borderVal;
            int[,] matrix;
            string fileNameInput = @"../../citire.txt";
            string fileNameOutput = @"../../afisare.txt";

            string[] lines = File.ReadAllLines(fileNameInput);

            n = lines.Count() - 1;
            m = int.Parse(lines[0].Split(' ')[1]);
            borderVal = int.Parse(lines[n].Split(' ')[m - 1]);
            matrix = new int[n, m];

            for (int i = 1; i <= n; i++)
            {
                string line = lines[i];
                int[] rows = (line.Split(' ')).Select(int.Parse).ToArray();

                for (int j = 0; j < rows.Length; j++)
                {
                    if (i - 1 == 0 || i == n || j == 0 || j == rows.Length - 1)
                    {
                        matrix[i - 1, j] = borderVal;
                    }
                    else
                    {
                        matrix[i - 1, j] = rows[j];

                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine($"Valoarea cautata: {borderVal}");
            Console.WriteLine($"{n} linii si {m} coloane");


            lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int j = 0; j < m; j++)
                {
                    stringBuilder.Append($"{matrix[i, j]} ");
                }
                lines[i] = stringBuilder.ToString().Trim();
            }


            File.WriteAllLines(fileNameOutput, lines);

            //verificare lines
            /*foreach (var item in lines)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadKey();
        }
    }
}
