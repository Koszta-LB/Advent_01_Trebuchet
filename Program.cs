using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<char> prenumbers = new List<char>();
            prenumbers.Add('0');
            prenumbers.Add('1');
            prenumbers.Add('2');
            prenumbers.Add('3');
            prenumbers.Add('4');
            prenumbers.Add('5');
            prenumbers.Add('6');
            prenumbers.Add('7');
            prenumbers.Add('8');
            prenumbers.Add('9');
            FileStream fs = new FileStream("datas.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
            //
             List<int> finnumb = new List<int>();
             for (int i = 0; i < list.Count; i++)
             {
                 int count = 0;
                 string temp = "";
                 for (int j = 0; j < list[i].Length; j++)
                 {
                     if (prenumbers.Contains(list[i][j]))
                     {
                         temp += list[i][j];
                         count++;
                     }
                 }
                 temp = temp[0].ToString() + temp[count-1];
                 finnumb.Add(int.Parse(temp));
             }
             Console.WriteLine(finnumb.Sum());
            Console.ReadKey();
        }
    }
}
