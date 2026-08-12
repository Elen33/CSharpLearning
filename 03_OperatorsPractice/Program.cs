namespace _03_OperatorsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                运算符：
                1. 算术运算符：+、-、*、/、%、++、--
                2. 比较运算符： ==、!=、>、<、>=、<=
                3. 赋值运算符：=、+=、-=、*=、/=、%=

                算术运算符的优先级：*、/优先级高于+、- 括号可以改变优先级。
             */

            // 练习1
            Console.WriteLine((15 + 8) * 3 - 20 / 4); // 结果64
            Console.WriteLine();


            // 练习2
            Console.WriteLine("请输入一个数：");
            string inputNumber = Console.ReadLine();
            if (int.TryParse(inputNumber, out int number))
            {
                // 输入的数值是有效的整数
                if (number % 2 == 0)
                {
                    Console.WriteLine("这是一个偶数。");
                }
                else
                {
                    Console.WriteLine("这是一个奇数。");
                }
            }
            else
            {
                Console.WriteLine("输入的不是有效的整数。");
            }
            Console.WriteLine();


            // 练习3
            Console.WriteLine("请输入一个总秒数：");
            string inputSeconds = Console.ReadLine();
            if (int.TryParse(inputSeconds, out int totalSeconds))
            {
                // 输入的数值是有效的整数
                int hours = totalSeconds / 3600;
                //double hours = (double)totalSeconds / 3600;   // 计算小时数，精确到小数
                //double resultHours = Math.Round(hours ,1);    // 保留一位小数
                int min = (totalSeconds % 3600) / 60;
                int sec = totalSeconds % 60;
                Console.WriteLine($"{totalSeconds}秒钟是：{hours}小时 {min}分钟 {sec}秒");
            }
            else
            {
                Console.WriteLine("输入的不是有效的整数。");
            }
            Console.WriteLine();


            // 练习4
            Console.WriteLine("请输入一个三位数：");
            string inputThreeDigit = Console.ReadLine();
            if (int.TryParse(inputThreeDigit, out int threeDigit))
            {
                // 输入的数值是有效的整数
                if (threeDigit < 100 || threeDigit > 999)
                {
                    Console.WriteLine("输入的不是三位数。");
                }
                else
                {
                    int hundreds = threeDigit / 100;
                    int tens = (threeDigit % 100) / 10;
                    int units = threeDigit % 10;
                    Console.WriteLine($"百位数是：{hundreds}，十位数是：{tens}，个位数是：{units}，三位数之和是：{hundreds + tens + units}");
                }
            }
            else
            {
                Console.WriteLine("输入的不是有效的整数。");
            }
        }
    }
}
