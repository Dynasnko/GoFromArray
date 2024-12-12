using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1112410015蘇昱臣
            MyHomeWork01();
            MyHomeWork02();
        }
        static void MyHomeWork01()
        {
            int[] one = new int[10];
            float[] two = new float[8];
            double[] three = new double[4];
            string[] four = new string[5];
            for (int i = 0; i < one.Length; i++) 
            {
                Console.WriteLine("請輸入第"+(i+1)+"個數值到int陣列one中");
                one[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("int陣列one {"+string.Join("、",one)+"}");
            Console.WriteLine("int陣列one的平均值" + one.Sum() / one.Length);
            Console.WriteLine("=======================");

            for (int i = 0; i < two.Length; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "個數值到float陣列two中");
                two[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("float陣列two {" + string.Join("、", two) + "}");
            Console.WriteLine("float陣列two的平均值" + two.Sum() / two.Length);
            Console.WriteLine("=======================");

            for (int i = 0; i < three.Length; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "個數值到double陣列three中");
                three[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("double陣列three {" + string.Join("、", three) + "}");
            Console.WriteLine("double陣列three的平均值" + three.Sum() / three.Length);
            Console.WriteLine("=======================");
            
            for (int i = 0; i < four.Length; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "個字串到string陣列four中");
                four[i] = Console.ReadLine();
            }
            Console.WriteLine("string陣列four {" + string.Join("、", four) + "}");
            Console.WriteLine("=======================");
        }
        static void MyHomeWork02()
        {
            int[] ArrayINT = { 1, 2, 3, 4, 5 };
            float[] ArrayFLOAT = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            double[] ArrayDOUBLE = { 1.22f, 2.33f, 3.44f, 4.55f, 5.66f };
            string[] ArraySTRING = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

            for (int i = 0; i < ArrayINT.Length; i++)
            {
                Console.WriteLine("陣列ArrayINT第" + (i + 1) + "個數值" + ArrayINT[i]);
            }
            Console.WriteLine("陣列ArrayINT的平均值" + ArrayINT.Sum() / ArrayINT.Length);
            Console.WriteLine("=======================");

            for (int i = 0; i < ArrayFLOAT.Length; i++)
            {
                Console.WriteLine("陣列ArrayFLOAT第" + (i + 1) + "個數值" + ArrayFLOAT[i]);
            }
            Console.WriteLine("陣列ArrayFLOAT的平均值" + ArrayFLOAT.Sum() / ArrayFLOAT.Length);
            Console.WriteLine("=======================");

            for (int i = 0; i < ArrayDOUBLE.Length; i++)
            {
                Console.WriteLine("陣列ArrayDOUBLE第" + (i + 1) + "個數值" + ArrayDOUBLE[i]);
            }
            Console.WriteLine("陣列ArrayDOUBLE的平均值" + ArrayDOUBLE.Sum() / ArrayDOUBLE.Length);
            Console.WriteLine("=======================");

            for (int i = 0; i < ArraySTRING.Length; i++)
            {
                Console.WriteLine("陣列ArraySTRING第" + (i + 1) + "個字串" + ArraySTRING[i]);
            }
            Console.WriteLine("=======================");
        }
    }
}
