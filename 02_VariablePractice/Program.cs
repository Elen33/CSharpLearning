namespace _02_VariablePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 什么是.NET 10.0 ？
            // .NET 10.0 是一个跨平台的开发框架，用于构建各种类型的应用程序，包括桌面应用、Web 应用、移动应用、云服务等。它是 .NET 平台的最新版本，提供了更高的性能、更好的安全性和更多的功能。

            // 什么是 C# 14.0 ？
            // C# 14.0 是 C# 编程语言的最新版本，提供了许多新的语言特性和改进，使开发者能够更高效地编写代码。C# 14.0 引入了模式匹配增强、记录类型、异步流、局部函数等新特性。

            // 什么是变量 ？
            // 变量是用于存储数据的命名内存位置。在编程中，变量可以用来保存不同类型的数据，如整数、字符串、布尔值等。变量的值可以在程序运行时改变。

            // 什么是常量 ？
            // 常量是指在程序运行过程中其值不能改变的变量。常量在定义时必须赋值，并且在整个程序中保持不变。常量通常用于表示固定的值，如数学常数、配置参数等。

            // 什么是数据类型 ？
            // 数据类型是编程语言中用于定义变量所能存储的数据的类型。常见的数据类型包括整数(int)、单精度浮点数(float)、双精度浮点数(double)、字符串(string)、字符(char)、布尔值(bool)等。数据类型决定了变量的大小、范围以及可以执行的操作。

            // 练习1
            string name1 = "张三";    // 定义一个字符串类型的变量 name1，并赋值为 "张三"
            byte age1 = 18;     // 定义一个字节类型的变量 age1，并赋值为 18 (取值范围是 0 到 255)
            byte height1 = 170;
            byte weight1 = 60;
            string workStatus1 = "已工作";
            Console.WriteLine($"姓名：{name1}");
            Console.WriteLine($"年龄：{age1}岁");
            Console.WriteLine($"身高：{height1}cm");
            Console.WriteLine($"体重：{weight1}kg");
            Console.WriteLine($"工作状况：{workStatus1}");
            Console.WriteLine();

            // 练习2
            string personInfo2 = "我叫Simon，我今年25岁。";
            string heightInfo2 = "我的身高是180cm。";
            string workInfo2 = "今天开始学习C#。";
            Console.WriteLine(personInfo2);
            Console.WriteLine(heightInfo2);
            Console.WriteLine(workInfo2);
            Console.WriteLine();

            // 练习3
            Console.WriteLine("请输入姓名：");
            string name3 = Console.ReadLine();
            Console.WriteLine("请输入年龄：");
            byte age3 = byte.Parse(Console.ReadLine());
            Console.WriteLine("请输入身高：（cm）");
            byte height3 = byte.Parse(Console.ReadLine());
            Console.WriteLine("请输入是否已婚：（已婚/未婚）");
            string maritalStatusInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("======个人信息======");
            Console.WriteLine($"姓名：{name3}");
            Console.WriteLine($"年龄：{age3}岁");
            Console.WriteLine($"身高：{height3}cm");
            Console.WriteLine($"婚姻状况：{maritalStatusInput}");
            Console.ReadKey();

            /*
             学习小结：
             1. .NET 10.0 是一个跨平台的开发框架，用于构建各种类型的应用程序。
             2. C# 14.0 是一种强类型的，面向对象的编程语言。
             3. 变量是用于存储数据的命名内存位置，常量是指在程序运行过程中其值不能改变的变量，以及变量如何声明和使用。
             4. 常用的数据类型包括整数(int)、单精度浮点数(float)、双精度浮点数(double)、字符串(string)、字符(char)、布尔值(bool)等。
             5. 字符串是由字符组成的序列，C# 提供了丰富的字符串操作方法，如 ToUpper()、ToLower()、Trim()、Replace()、Contains()、StartsWith()、EndsWith() 等。
            */
            Console.WriteLine("请输入你的名字：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄：");
            //.Parse() 方法用于将字符串转换为指定的数据类型。在这里，byte.Parse(Console.ReadLine()) 将用户输入的字符串转换为 byte 类型的整数。
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine($"我的名字是{name}，我今年{age}岁。");

            string hello = "Hello,World!";
            // .Length 属性用于获取字符串的长度，即字符串中字符的数量。它返回一个整数值，表示字符串中字符的总数，该属性为只读，不可赋值更改。
            int length = hello.Length;
            Console.WriteLine(length);


            // string字符串的常用方法（函数）：
            // 1. ToUpper()：将字符串转换为大写字母。
            string upperHello = hello.ToUpper();
            Console.WriteLine(upperHello);

            // 2. ToLower()：将字符串转换为小写字母。
            string lowerHello = hello.ToLower();
            Console.WriteLine(lowerHello);

            // 3. Trim()：去除字符串两端的空白字符。
            string txt = " Hello ";
            string txtTrim = txt.Trim();
            Console.WriteLine(txt);
            Console.WriteLine(txtTrim);

            // 4. Replace(string oldValue, string newValue)：将字符串中的指定子字符串替换为新的子字符串。
            string oldHello = "Hello,World!";
            string newHello = oldHello.Replace("World!", "C#!");
            Console.WriteLine(newHello);

            // 5. Contains(string value)：判断字符串是否包含指定的子字符串，返回布尔值。
            string testHello = "HELLO,WORLD!";
            bool containsHello1 = testHello.Contains("OR");
            bool containsHello2 = testHello.Contains("K");
            Console.WriteLine(containsHello1);
            Console.WriteLine(containsHello2);

            // 6. StartsWith(string value)：判断字符串是否以指定的子字符串开头，返回布尔值。
            bool startsWithHello = testHello.StartsWith("HE");
            Console.WriteLine(startsWithHello);

            // 7. EndsWith(string value)：判断字符串是否以指定的子字符串结尾，返回布尔值。
            bool endsWithHello = testHello.EndsWith("LD!");
            Console.WriteLine(endsWithHello);

            // 常量的定义 const
            // const 关键字用于定义常量，常量在程序运行过程中其值不能改变。常量在定义时必须赋值，并且在整个程序中保持不变。常量通常用于表示固定的值，如数学常数、配置参数等。
            const double PI = 3.14159265358979323846;
            const string AppName = "MyApp";
            Console.WriteLine($"圆周率是：{PI}");
            Console.WriteLine($"应用程序名称是：{AppName}");
        }
    }
}
