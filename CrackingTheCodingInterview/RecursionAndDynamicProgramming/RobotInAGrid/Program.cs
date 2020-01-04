using System;
using System.Collections.Generic;
using System.Drawing;

namespace RobotInAGrid
{
    // a robot is sitting in top left corner of a grid. write an algorithm
    // for a robot to find a way to the bottom right. he can only move right or down
    // and certain cells are off-limit.
    class Program
    {
        // t f t t t
        // t t t t t
        // f f f t t
        // f f t t t
        // t t t t t
        static void Main(string[] args)
        {
            bool[][] grid = new bool[5][];
            grid[0]= new bool[5]{true, false, true, true, true};
            grid[1] = new bool[5]{true, true, true, true, true};
            grid[2] = new bool[5]{false, false, false, true, true};
            grid[3] = new bool[5]{false, false, true, true, true,};
            grid[4] = new bool[5]{true, true, true, true, true};
            var result = FindPath(grid);
            if(result!=null)
            {
                foreach (var item in result)
                {
                    Console.Write($"[{item.X},{item.Y}] => ");
                }
            }
            else
            System.Console.WriteLine("No path available");
        }

        private static List<Point> FindPath(bool[][] grid)
        {
            var path = new List<Point>();
            var badPoints = new List<Point>();
            if(FindPath(grid, path, badPoints,grid.Length - 1, grid.Length - 1)) return path;
            else return null;
        }

        private static bool FindPath(bool[][] grid, List<Point> path, List<Point> badPoints, int row, int column)
        {
            if(row<0 || column<0  || !grid[row][column]) return false;
            var currentPoint = new Point(row,column);
            if(badPoints.Contains(currentPoint)) return false;
            bool finished = row==0 && column==0;
            if(finished || FindPath(grid,path,badPoints,row-1,column) || FindPath(grid,path,badPoints,row,column-1))
            {
                path.Add(currentPoint);
                return true;
            }
            badPoints.Add(currentPoint);
            return false;
        }
    }
}
