using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1112410043_1205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float score = 0;
            Console.WriteLine("請輸入成績:");
            try
            {
                score = float.Parse(Console.ReadLine());
            }
            catch 
            { 
            Console.WriteLine("輸入資料錯誤");
            return;
            }
            Console.WriteLine("你輸入的分數為:"+score.ToString());
        }
    }
}
