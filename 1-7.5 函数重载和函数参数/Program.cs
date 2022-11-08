using System;

namespace _1_7._5_函数重载和函数参数
{
    // 1.函数重载
    /* 同一个函数名称，不同的参数
     * 实际是不同的函数。
     */

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }

        // 重载：函数名相同哦，函数参数不同。
        // 由C#编译器决定实际调用哪个函数。
        static double Add(double a, double b)
        {
            return a + b;
        }
     
        static int Add(int n)
        {
            return n + 1;
        }

        //// ----------------------------------------
        //static int Mul(int a)
        //{
        //    return a * 2;
        //}

        // 2.参数默认值 
        // 可省略后面的参数，省略的参数取默认值
        // 默认参数，如果没有给定b的值，b取2
        // 默认参数捣乱的概率大于灵活的使用
        // 默认参数必须放在后面

        static int Mul(int a, int b=2, int c = 1)
        {
            return a * b * c;
        }

        // 3.可变参数：params（很少使用到，但是要看得懂）
        // 针对不确定个数的参数，也能方便使用
        // 函数Log里面添加的所有字段都可以打印
        static void Log(params string[] a)
        {
            for (int i = 0;i<a.Length;i++)
            { Console.Write(a[i]);Console.Write(" "); }
            Console.WriteLine();
        }
      

        static void Main(string[] args)
        {
            int c = Add(3, 5);
            Console.WriteLine($"c={c}");

            float f2 = Add(3);

            float d = Add(3.5f, 1.2f); 

            Console.WriteLine($"d={d}");

            Mul(35, 2);
            Mul(c, 2);
            Mul((int)f2, 2);
            Mul(666, 2);
            Mul(2, 2, 2);

            // 2.命名参数
            // 针对不确定个数的参数，也能方便处理
            Mul(2, b:2, c:2);

            Console.WriteLine("{0},{1},{2},{3},{4}", c, f2, d, Add(c, f2), 333);

            Log("Hello", " ", "World", "!");

            Console.ReadKey();
        }
    }
}
