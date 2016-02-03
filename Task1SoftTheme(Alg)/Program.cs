using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1SoftTheme_Alg_
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("INPUT.txt");
            sw.Write("11110000101010000111100001111111111111110001110001011111111");
            sw.Close();
            string line = File.ReadAllText("INPUT.txt");
            //Первый способ
            int max2 = 0;
            int currentam = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '1')
                {
                    currentam++;
                    if (currentam > max2)
                        max2 = currentam;
                }
                else
                    currentam = 0;


            }
         //   Console.WriteLine(max2);
            sw = new StreamWriter("OUTPUT.txt");
            sw.Write(max2);
            sw.Close();
            Console.ReadLine();
        }
    }
}
