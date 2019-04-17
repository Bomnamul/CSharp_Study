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
            line.Draw(new Node(3, 3), new Node(7, 7));
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
        }
    }
    public class LineDrawing
    {
        byte[][] grid;
        public byte[] lineGrid;
        public LineDrawing(byte[][] grid)
        {
            this.grid = grid;
        }
        public void Draw(Node start, Node end)
        {

        }
    }
    public class Node
    {
        public int row;
        public int column;
        public Node(int row, int column)
        {
            this.row = row;
            this.column = column;
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
