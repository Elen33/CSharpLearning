namespace _07_WhileLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * while循环语法：
             *  while (条件表达式(真))
             *  {
             *      循环体语句;
             *  }
             *  
             * do-while循环语法：
             *  do
             *  {
             *      循环体语句;
             *  } while (条件表达式(真));
             *  
             *  while循环：先判断条件再执行循环体，可能一次都不执行
             *  do-while循环：先执行循环体再判断条件，至少执行一次
             *  区别：执行顺序不同，do-while保证至少执行一次循环
             *  适用场景：while循环适用于循环次数不确定的情况，do-while循环适用于至少需要执行一次的情况
             *  与for循环的区别：for循环适用于循环次数已知的情况，while和do-while适用于循环次数不确定的情况
             *  注意事项：注意更新循环条件，避免死循环，注意循环体内的逻辑，避免无限循环
             *  循环控制：可以使用break语句跳出循环，使用continue语句跳过本次循环，使用return语句退出方法
             *  
             */


            int count = 1;
            int sum = 0;
            while (count <= 100)
            {
                sum += count;
                Console.WriteLine(count);
                count++;
                //count+=2; //控制步长
            }
            //Console.WriteLine($"1到100奇数之和={sum}");
            //Console.WriteLine($"1到100偶数之和={sum}");
            Console.WriteLine($"1到100所有数之和={sum}");


            int choice = 0;
            do
            {

                Console.WriteLine("1.添加数据");
                Console.WriteLine("2.删除数据");
                Console.WriteLine("3.查询数据");
                Console.WriteLine("4.退出程序");
                Console.WriteLine("请选择你要执行的操作：(1-4)");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("输入的不是数字，请输入一个有效的数字！按任意键继续！");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (choice == 1)
                {
                    // 添加数据的逻辑
                    Console.WriteLine("执行添加数据，按任意键继续");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (choice == 2)
                {
                    // 删除数据的逻辑
                    Console.WriteLine("执行删除数据，按任意键继续");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 3)
                {
                    // 查询数据的逻辑
                    Console.WriteLine("执行查询数据，按任意键继续");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    // 退出程序的逻辑
                    Console.WriteLine("执行退出程序");
                    return;
                }
                else
                {
                    Console.WriteLine("无效选择，请重新输入！按任意键继续");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);

            /*
            int input = 0;
            do
            {
                Console.WriteLine("请输入一个正数：");
                if (!int.TryParse(Console.ReadLine(), out input))    //判断输入是否为数字
                {
                    Console.WriteLine("输入的不是数字，请输入一个有效的数字！");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (input <= 0)
                {
                    Console.WriteLine("你输入的不是正数，请重新输入！");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("输入有效！");
                    return;
                }
            } while (true);
            */
        }
    }
}
