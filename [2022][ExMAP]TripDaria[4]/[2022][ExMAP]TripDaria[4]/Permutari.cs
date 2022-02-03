using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul6
{
    public class Permutari
    {
        static int n;
        static int[,] ma;

        static void citire()
        {
            TextReader load = new StreamReader("data.in");
            n = int.Parse(load.ReadLine());
            ma = new int[n, n];
            
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local_data = buffer.Split(' ');
                int x = int.Parse(local_data[0]);
                int y = int.Parse(local_data[1]);

                ma[x - 1, y - 1] = 1;
                ma[y - 1, x - 1] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(ma[i, j] + " ");
                Console.WriteLine(); 
              
            }
            Console.WriteLine();
        }

        static bool gasitDrumH = false;

        static void back(int k, int n, int[] sol, bool[] vis)
        {
            if (k >= n)
            {
                bool drumHamiltonian = true;
                for (int i = 1; i < n; i++)
                {
                    if(ma[sol[i]-1,sol[i-1]-1]==0 && ma[sol[i-1]-1, sol[i]-1] == 0)
                    {
                        drumHamiltonian = false;
                        break;
                    }
                }
                if(drumHamiltonian==true)
                {
                    if(gasitDrumH==false)
                        Console.WriteLine("Drumuri hamiltoniene:");

                    gasitDrumH = true;
                    for (int i = 0; i < n; i++)
                        Console.Write(sol[i] + " ");
                    Console.WriteLine();
                }
                
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        back(k + 1, n, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }
        public static void rezolvare()
        {
            citire();
            int[] sol = new int[n];
            bool[] visited = new bool[n];
            //asigurati-va ca visited[i] are valori false
            back(0, n, sol, visited);
            if (gasitDrumH == false)
            {
                Console.Write("Nu exista drumuri hamiltoniene");
            }
            Console.ReadKey();
        }
        //to do la laborator: sa afisam toate drumurile hamiltoniene, pe baza permutarilor de mai sus
    }
}
