using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            //string path = @"D:\Учеба\прога\2016\text\solvePlus.txt";
            string path = @"D:\Учеба\прога\2016\text\solveAll2.txt";
            //string path = @"D:\Учеба\прога\2016\text\solveClearBrackets.txt";

            str = File.ReadAllText(path);
            Console.WriteLine("Что считать?");
            //Console.WriteLine(str);
            Calc A = new Calc();
            //Console.WriteLine(A.CountAll(str));
            Console.WriteLine(A.Count(str));
            ////double num = Convert.ToDouble("-1.5");
            //double num = Double.Parse("-1,5");

            Console.ReadLine();
        }
    }
}
