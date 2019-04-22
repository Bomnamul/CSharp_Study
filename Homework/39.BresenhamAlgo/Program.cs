using System;
using System.Collections.Generic;

namespace _39.BresenhamAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> print = Console.WriteLine;

            var grid = new byte[][]
            {
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            var line = new LineDrawing(grid);
            line.Draw(new Node(2, 2), new Node(7, 7));
            print(line.lineGrid[0].Stringify());
            print(line.lineGrid[1].Stringify());
            print(line.lineGrid[2].Stringify());
            print(line.lineGrid[3].Stringify());
            print(line.lineGrid[4].Stringify());
            print(line.lineGrid[5].Stringify());
            print(line.lineGrid[6].Stringify());
            print(line.lineGrid[7].Stringify());
            print(line.lineGrid[8].Stringify());
            print(line.lineGrid[9].Stringify());
            print("");
            print(line.lineGrid[0].Stringify() == " 0  0  0  0  0  0  0  0  0  0");
            print(line.lineGrid[1].Stringify() == " 0  0  0  0  0  0  0  0  0  0");
            print(line.lineGrid[2].Stringify() == " 0  0  1  0  0  0  0  0  0  0");
            print(line.lineGrid[3].Stringify() == " 0  0  0  1  0  0  0  0  0  0");
            print(line.lineGrid[4].Stringify() == " 0  0  0  0  1  0  0  0  0  0");
            print(line.lineGrid[5].Stringify() == " 0  0  0  0  0  1  0  0  0  0");
            print(line.lineGrid[6].Stringify() == " 0  0  0  0  0  0  1  0  0  0");
            print(line.lineGrid[7].Stringify() == " 0  0  0  0  0  0  0  1  0  0");
            print(line.lineGrid[8].Stringify() == " 0  0  0  0  0  0  0  0  0  0");
            print(line.lineGrid[9].Stringify() == " 0  0  0  0  0  0  0  0  0  0");
        }
    }
    public class LineDrawing
    {
        byte[][] grid;
        public byte[][] lineGrid;
        public LineDrawing(byte[][] grid)
        {
            this.grid = grid;
            this.lineGrid = new byte[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                this.lineGrid[i] = new byte[grid[0].Length];
            }
        }
        public void Draw(Node start, Node end)
        {

        }
        public double Solver(Node start, Node end)
        {
            // int w = end.Y - start.Y;
            // int h = end.X - start.X;
            // double b = start.X - ((h / w) * start.Y);
            // double y = ((h / w) * x) + b;

            return -1;
        }
    }
    public class Node
    {
        public int X {get; set;}
        public int Y {get; set;}
        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public static class ClassExtension
    {
        public static string Stringify<T>(this IEnumerable<T> list)
        {
            string s = "";
            foreach(var v in list)
            {
                s += string.Format("{0, 2}", v) + " ";
            }
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
    }
}
