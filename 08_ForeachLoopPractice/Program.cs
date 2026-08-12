namespace _08_ForeachLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * foreach循环语法：
             *  foreach (类型 变量名 in 集合)
             *      {
             *          
             *      }
             * foreach循环用于遍历集合中的每个元素，适用于数组、列表等集合类型。它的优点是简洁易读，缺点是无法修改集合中的元素。
             *      
             * 数组的声明：
             *  类型[] 数组名 = new 类型[长度];
             * 数组的初始化：
             *  类型[] 数组名 = new 类型[长度] { 元素1, 元素2, ... }
             *  类型[] 数组名 = { 元素1, 元素2, ... }
             * 数组的下标从0开始，访问数组元素时使用数组名[下标]，下标范围为0到长度-1。
             * 
             */

            string[] test = new string[5] { "she", "say", "hello", "world", "test" };
            foreach (string s in test)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine(test.Length);


            int[] number = { 12, 2, 3, 41, 25, 6, 77, 8, 39, 11 };
            int sum = 0;
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1 - i; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
                sum += number[i];
            }
            double avg = (double)sum / number.Length;
            Console.WriteLine($"Average: {avg:F2}");

            /*
            foreach (int n in number)
            {
                if (number[0] < n)
                {
                    number[0] = n;
                }
            }
             */
            //Console.WriteLine($"Maximum value: {number[0]}");
            //Console.WriteLine($"Minimum value: {number[0]}");
            Console.WriteLine();

            Random randomNumber = new Random();
            int[] redNumber = new int[6];
            for (int i = 0; i < redNumber.Length; i++)
            {
                redNumber[i] = randomNumber.Next(1, 34);
                Console.Write(redNumber[i] + " ");
            }

            string text = "Hello,World!";
            int count = 0;
            foreach (char n in text)
            {
                if (n == 'l')
                {
                    count++;
                }
            }
            Console.WriteLine($"'l'出现了: {count}次");
        }
    }
}
