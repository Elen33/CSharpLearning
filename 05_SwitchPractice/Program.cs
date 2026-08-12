namespace _05_SwitchPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                小结：
                switch语句的作用：用于根据一个表达式的值，从多个选项中选择一个执行。
                基本语法：switch、case、break、default的配合使用。
                switch (expression)
                    case value1:
                        // 执行代码块1
                        break;
                    case value2:
                        // 执行代码块2
                        break;
                    default：
                        // 执行默认代码块
                        break;
                1.执行流程：表达式值匹配case标签，执行对应分支，遇到break跳出。
                2.break的重要性：每个case分支后必须有break，否则会继续执行下一个case分支，可能导致逻辑错误。
                3.default的作用：当没有case匹配时，执行default分支，通常用于处理异常或默认情况。
                4.使用场景：多个固定值的判断，如菜单选择，状态判断。
                5.与if-else的区别：switch适用于固定值判断，if-else适用于范围或复杂条件判断。
            */

            // 练习 1
            Console.WriteLine("请输入月份数字：（1-12）");
            string inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int month);
            switch (month)
            {
                case 1:
                    Console.WriteLine("一月");
                    break;
                case 2:
                    Console.WriteLine("二月");
                    break;
                case 3:
                    Console.WriteLine("三月");
                    break;
                case 4:
                    Console.WriteLine("四月");
                    break;
                case 5:
                    Console.WriteLine("五月");
                    break;
                case 6:
                    Console.WriteLine("六月");
                    break;
                case 7:
                    Console.WriteLine("七月");
                    break;
                case 8:
                    Console.WriteLine("八月");
                    break;
                case 9:
                    Console.WriteLine("九月");
                    break;
                case 10:
                    Console.WriteLine("十月");
                    break;
                case 11:
                    Console.WriteLine("十一月");
                    break;
                case 12:
                    Console.WriteLine("十二月");
                    break;
                default:
                    Console.WriteLine("输入的月份数错误。");
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            // 练习 2
            Console.WriteLine("请输入等级：（A-D）");
            string inputGrade = Console.ReadLine();
            switch (inputGrade.ToUpper())
            {
                case "A":
                    Console.WriteLine("优秀");
                    break;
                case "B":
                    Console.WriteLine("良好");
                    break;
                case "C":
                    Console.WriteLine("及格");
                    break;
                case "D":
                    Console.WriteLine("不及格");
                    break;
                default:
                    Console.WriteLine("输入的等级错误。");
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            // 练习 3
            Console.WriteLine("=========");
            Console.WriteLine("1.开始游戏");
            Console.WriteLine("2.查看角色");
            Console.WriteLine("3.设置");
            Console.WriteLine("4.退出");
            Console.WriteLine("=========");
            Console.WriteLine();
            Console.WriteLine("请选择操作：");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("开始游戏，加载中。。。");
                    break;
                case 2:
                    Console.WriteLine("查看角色，正在加载角色信息。");
                    break;
                case 3:
                    Console.WriteLine("正在进入设置");
                    break;
                case 4:
                    Console.WriteLine("正在退出游戏");
                    break;
                default:
                    Console.WriteLine("输入的选择错误。");
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            // 练习 4
            Console.WriteLine("=====简单计算器=====");
            Console.WriteLine("请输入第一个数字：");
            bool isValid1 = int.TryParse(Console.ReadLine(), out int number1);
            if (!isValid1)
            {
                Console.WriteLine("输入的第一个数字无效。");
                return;
            }
            Console.WriteLine("请输入第二个数字：");

            bool isValid2 = int.TryParse(Console.ReadLine(), out int number2);
            if (!isValid2)
            {
                Console.WriteLine("输入的第二个数字无效。");
                return;
            }

            Console.WriteLine("请输入需要执行的运算：（+、-、*、/）");
            string operation = Console.ReadLine();
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"结果：{result}");
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"结果：{result}");
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"结果：{result}");
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = (double)number1 / number2;
                        Console.WriteLine($"结果：{result:F2}");
                    }
                    else
                    {
                        Console.WriteLine("结果：错误！除数不能为零。");
                    }
                    break;
                default:
                    Console.WriteLine("错误：无效的运算符。");
                    break;
            }

            /*
            
            // 练习1
            Console.WriteLine("请输入一个月份数：（1-12）");
            bool isMonthValid = int.TryParse(Console.ReadLine(), out int month);
            if (!isMonthValid)
            {
                Console.WriteLine("输入的值非法。");
                return;
            }
            string monthName = month switch
            {
                1 => "一月",
                2 => "二月",
                3 => "三月",
                4 => "四月",
                5 => "五月",
                6 => "六月",
                7 => "七月",
                8 => "八月",
                9 => "九月",
                10 => "十月",
                11 => "十一月",
                12 => "十二月",
                _ => "输入的月份数错误。"
            };
            Console.WriteLine(monthName);
            Console.ReadKey();
            Console.Clear();
           
            // 练习2
            Console.WriteLine("请输入等级：（A-D）");
            string inputGrade = Console.ReadLine();
            string gradeMessage = inputGrade?.ToUpper() switch
            {
                "A" => "优秀",
                "B" => "良好",
                "C" => "及格",
                "D" => "不及格",
                _ => "输入的等级错误。"
            };
            Console.WriteLine(gradeMessage);
            Console.ReadKey();
            Console.Clear();

            // 练习3
            Console.WriteLine("请输入一个月份数：（1-12）");
            bool isMonthValid2 = int.TryParse(Console.ReadLine(), out int month2);
            if (!isMonthValid2)
            {
                Console.WriteLine("输入的值非法。");
                return;
            }
            else
            {
                string season = month2 switch
                {
                    1 => "一月是冬季",
                    2 => "二月是冬季",
                    3 => "三月是春季",
                    4 => "四月是春季",
                    5 => "五月是春季",
                    6 => "六月是夏季",
                    7 => "七月是夏季",
                    8 => "八月是夏季",
                    9 => "九月是秋季",
                    10 => "十月是秋季",
                    11 => "十一月是秋季",
                    12 => "十二月是冬季",
                    _ => "输入的月份数错误。"
                };
                Console.WriteLine(season);
            }

            
            //C# 9.0 引入了模式匹配增强功能，允许在 switch 表达式中使用模式匹配。
            //string season2 = month2 switch
            //{
            //    1 or 2 or 12 => "冬季",
            //    3 or 4 or 5 => "春季",
            //    6 or 7 or 8 => "夏季",
            //    9 or 10 or 11 => "秋季",
            //    _ => "输入的月份数错误。"
            //};
            
            // 练4
            Console.WriteLine("请输入第一个数字：");
            bool isNumber1Valid = int.TryParse(Console.ReadLine(), out int number1);
            if (!isNumber1Valid)
            {
                Console.WriteLine("输入的值非法。");
                return;
            }
            Console.WriteLine("请输入第二个数字：");
            bool isNumber2Valid = int.TryParse(Console.ReadLine(), out int number2);
            if (!isNumber2Valid)
            {
                Console.WriteLine("输入的值非法。");
                return;
            }
            Console.WriteLine("请输入要执行的运算：（+、-、*、/）");
            string operation = Console.ReadLine();
            string result = operation switch
            {
                "+" => (number1 + number2).ToString(),
                "-" => (number1 - number2).ToString(),
                "*" => (number1 * number2).ToString(),
                "/" => number2 != 0 ? ((double)number1 / number2).ToString("F2") : "除数不能为0！",
                _ => "无效的运算符！"
            };
            Console.WriteLine($"计算结果为：{result}");

            
            //switch 表达式
            //C# 8.0 引入，可以返回值。
            //基本语法：
            //var result = expression switch
            //{
            //    pattern1 => value1,
            //    pattern2 => value2,
            //    _=> defaultValue
            //};
            //使用场景：需要返回值的简单映射场景。
            //与switch语句的区别“表达式返回值，语句执行操作。
            */
        }
    }
}
