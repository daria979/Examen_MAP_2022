using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022__ExMap_TripDaria_3_
{
    class Program
    {
        /// <summary>
        /// 105%8 = 1 -> C[2][1] => Problema 7
        /// </summary>
        /// <param name="args"></param>
        
            public static int x;
            public static int y;
            static void Main(string[] args)
            {
                TextReader load = new StreamReader(@"..\..\citire.txt");
                TextWriter output = new StreamWriter(@"..\..\afisare.txt");
                string buffer = load.ReadLine();
                x = int.Parse(buffer.Split(' ')[0]);
                y = int.Parse(buffer.Split(' ')[1]);
                int z = 9;

                output.Write(y);
                output.Write(' ');
                output.Write(x);
                output.Write(' ');
                while (z > 8)
                {
                    z = 2 * x - y + 2;
                    output.Write(z);
                    output.Write(' ');
                    y = x; x = z;
                }
                output.Write(3);
                output.Write(' ');
                output.Write(0);
                output.Write(0);
                
            }
        
    }
}
