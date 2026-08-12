namespace _01_HelloWorldPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // 输出 "Hello, World!" 到控制台

            Console.WriteLine("Please input number A: ");
            int a = int.Parse(Console.ReadLine());  // 读取用户输入的数字 A，并将其转换为整数类型（不做验证）
            Console.WriteLine("Please input number B: ");
            int b = int.Parse(Console.ReadLine());  // 读取用户输入的数字 B，并将其转换为整数类型（不做验证）

            Console.WriteLine($"{a} + {b} = {a + b}");  // 输出 A + B 的结果 
        }
    }
}
