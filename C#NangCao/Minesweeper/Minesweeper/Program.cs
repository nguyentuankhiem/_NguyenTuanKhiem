using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] map = new int[9, 9];
            int[,] player = new int[9, 9];
            int flags = 10;
            int mine = 0;
            bool isOver = false;
            while (mine < 10)
            {
                Random rnd = new Random();
                int i = rnd.Next(9);
                int j = rnd.Next(9);
                if (map[i, j] != -1)
                {
                    map[i, j] = -1;
                    mine++;
                }

            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (map[i, j] != -1)
                    {
                        int count = 0;
                        for (int row = i - 1; row <= i + 1; row++)
                        {
                            for (int col = j - 1; col <= j + 1; col++)
                            {
                                if (row >= 0 && col >= 0 && row < 9 && col < 9 && map[i, j] != -1)
                                {
                                    if (map[row, col] == -1)
                                    {
                                        count += 1;
                                    }
                                }
                            }
                        }
                        map[i, j] = count;
                    }
                }
            }

            // start
            while (!isOver)
            {
                Console.Clear();
                Console.WriteLine("    MINESWEEPER");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
                // helper up row
                Console.Write("   ");
                for (int i = 0; i < 9; i++)
                {
                    if (i < 8)
                    {
                        Console.Write(i + " ");
                        
                        
                    }

                    else
                    {
                        Console.Write(i + "\n");

                    }

                    
                }
                
                Console.WriteLine();
                for (int row = 0; row < 9; row++)
                {
                    Console.Write(row + "| "); // helper col
                    for (int col = 0; col < 9; col++)
                    {
                        if (player[row, col] == -2)
                        {
                            Console.Write("F ");
                        }
                        else if (player[row, col] == -3 && map[row, col] > 0)
                        {
                            Console.Write(map[row, col] + " ");
                        }
                        else if (player[row, col] == -3)
                        {
                            Console.Write("- ");
                        }
                        else { Console.Write("# "); }
                    }
                    Console.Write("|" + row + " "); // helper col
                    Console.WriteLine();
                }
                Console.WriteLine();
                // helper down row
                Console.Write("   ");
                for (int i = 0; i < 9; i++)
                {
                    if (i < 8)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write(i + "\n");
                    }
                }
                Console.WriteLine("\nSo co con lai: " + flags);
                Console.Write("F de cam co, Q de ket thuc tro choi, Enter de bat dau: ");
                string input = Console.ReadLine().ToLower();
                //Console.WriteLine();
                if (input.Contains("q"))
                {
                    
                    Console.WriteLine("\nKet thuc tro choi!");
                    isOver = true;
                }
                else if (input.Contains("f"))
                {
                    while (!isOver)
                    {
                       try
                        {
                            Console.Write("Cam co o hang nao (0-8): ");
                            int rowf = int.Parse(Console.ReadLine());
                            Console.Write("Cam co o cot nao (0-8): ");
                            int colf = int.Parse(Console.ReadLine());
                            if (player[rowf, colf] != -3 && player[rowf, colf] != -2 && flags > 0)
                            {
                                player[rowf, colf] = -2;
                                flags--;
                                break;
                            }
                            else if (player[rowf, colf] == -2)
                            {
                                player[rowf, colf] = 0;
                                flags++;
                                break;
                            }
                            else { Console.WriteLine("O nay da duoc chon roi!"); }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Vui long nhap lai!");
                        }
                    }
                }
                else
                {
                    while (!isOver)
                    {
                        try
                        {
                            Console.Write("Mo o hang nao (0-8): ");
                            int irow = int.Parse(Console.ReadLine());
                            Console.Write("Mo o cot nao (0-8): ");
                            int icol = int.Parse(Console.ReadLine());

                            if (player[irow, icol] == -3)
                            {
                                Console.WriteLine("O nay da mo roi");
                            }
                            else if (player[irow, icol] == -2)
                            {
                                Console.WriteLine("O nay da cam co roi");
                            }
                            else if (map[irow, icol] == -1)
                            {
                                //Console.Clear();
                                Console.WriteLine("\nThua!");
                                isOver = true;

                            }
                            else
                            {
                                player[irow, icol] = -3;
                                Open(9, map, player, irow, icol);
                                break;
                            }
                        }
                        catch (Exception loi)
                        {
                            Console.WriteLine("Vui long nhap lai!");
                        }
                    }
                }
                int count = 0;
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        if (map[row, col] == -1 && player[row, col] != -2)
                        {
                            count += 1;
                        }
                    }
                }
                if (count == 0)
                {
                    //Console.Clear();
                    Console.WriteLine("\nThang!");
                    isOver = true;
                }
                
            }
            // show map
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (map[i, j] == -1)
                    {
                        Console.Write("M ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void Open(int size, int[,] map, int[,] player, int row, int col)
        {
            if (map[row, col] != -3 && map[row, col] > 0)
            {
                player[row, col] = -3;
            }
            else if (map[row, col] == 0)
            {
                player[row, col] = -3;
                if (row - 1 >= 0 && player[row - 1, col] != -3)
                {
                    Open(9, map, player, row - 1, col);
                }
                if (row + 1 < 9 && player[row + 1, col] != -3)
                {
                    Open(9, map, player, row + 1, col);
                }
                if (col - 1 >= 0 && player[row, col - 1] != -3)
                {
                    Open(9, map, player, row, col - 1);
                }
                if (col + 1 < 9 && player[row, col + 1] != -3)
                {
                    Open(9, map, player, row, col + 1);
                }
            }
        }
  
    }
}
