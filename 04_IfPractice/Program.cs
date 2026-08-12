namespace _04_IfPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if语句语法：if (bool类型条件表达式)
            //            {
            //
            //            }
            //            else
            //            {
            //
            //            }

            /*
              if (分支判断)
              {
                   判断结果为真要执行的代码
              }
              else if (多分支判断)
              {
                   判断结果为真要执行的代码
              }
              else
              {
                    都不满足执行的代码
              }

              if-else适用于范围或复杂条件判断。
             */

            // 练习1
            Console.WriteLine("请输入年份：");
            string inputYear = Console.ReadLine();
            if (int.TryParse(inputYear, out int year))
            {
                // 输入的数值是有效的整数
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine($"{year}是闰年。");
                }
                else
                {
                    Console.WriteLine($"{year}不是闰年。");
                }
            }
            else
            {
                Console.WriteLine("输入的不是有效的整数。");
            }
            Console.WriteLine();


            // 练习2
            Console.WriteLine("请输入用户名：");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            if (username != "admin")
            {
                Console.WriteLine("用户名错误，登录失败。");
            }
            else if (password != "123456")
            {
                Console.WriteLine("密码错误，登录失败。");
            }
            else
            {
                Console.WriteLine("登录成功。");
            }
            Console.WriteLine();


            // 练习3
            Console.WriteLine("请输入你的身高：（米）");
            string inputheight = Console.ReadLine();
            Console.WriteLine("请输入你的体重：（千克）");
            string inputweight = Console.ReadLine();
            // 验证输入是否为有效的身高
            if (!double.TryParse(inputheight, out double height))
            {
                Console.WriteLine("输入的身高不是有效的数字。");
            }
            // 验证输入是否为有效的体重
            else if (!double.TryParse(inputweight, out double weight))
            {
                Console.WriteLine("输入的体重不是有效的数字。");
            }
            else
            {
                double bmi = weight / (height * height);
                if (bmi < 18.5)
                {
                    Console.WriteLine($"你的BMI值为{bmi:F2}，你的体重过轻!");
                }
                else if (bmi < 24)
                {
                    Console.WriteLine($"你的BMI值为{bmi:F2}，你的体重正常。");
                }
                else if (bmi < 28)
                {
                    Console.WriteLine($"你的BMI值为{bmi:F2}，你的体重过重。");
                }
                else
                {
                    Console.WriteLine($"你的BMI值为{bmi:F2}，你的体重肥胖!");
                }
            }
        }
    }
}
