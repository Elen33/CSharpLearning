namespace _06_ForLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * for循环语法：
             *  for (初始化表达式; 条件表达式; 迭代表达式)
             *  {
             *      循环体语句;
             *  }
             *  
             *  常见错误：忘记更新循环变量，条件错误，作用域错误，分号位置错误
             */

            // 练习 1
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();

            // 练习 2
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"1+2+3+...+100={sum}");
            Console.ReadKey();
            Console.Clear();

            // 练习 3
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            // 练习 4
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
