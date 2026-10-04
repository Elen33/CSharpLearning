namespace _11_ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             过程式编程的问题：
                    1、数据和操作是分离的，数据散落在各处，难以管理；
                    2、代码重复，相似的功能需要重复编写；
                    3、难以维护和扩展，修改一个地方可能影响其他地方；

             面向对象编程的优势：
                    1、把相关的数据和操作封装在一起，形成一个整体；
                    2、代码可以复用，定义一次，使用多次；
                    3、易于维护和扩展，修改一个类的实现不会影响其他类；

            类和对象的关系：
            在编程中，我们可以定义一个汽车类（Car），来描述所有汽车的共同特征。然后，我们可以根据这个类创建多个汽车对象，比如：
                    一辆红色的宝马；
                    一辆蓝色的奔驰；
                    一辆黑色的奥迪；

            类（CLass）就像是一个模板或蓝图，定义了对象的共同特征和行为；在C#中，我们使用关键字class来定义一个类，类中可以包含属性（Property）、方法（Method）、字段（Field）等成员；
            对象（Object）是根据类创建出来的具体实例，每个对象都有自己的属性值和状态；在C#中，我们使用关键字new来创建对象，并通过构造函数（Constructor）来初始化对象的属性值；

            一个类可以创建多个对象，每个对象都是独立的实例，修改一个对象不会影响其他对象，每个对象都拥有自己的属性值和状态；在C#中，我们可以通过类名.属性名或类名.方法名来访问对象的属性和方法；
             */


            /*
             假设我们要管理学生信息，我们可以定义一个Student类：

             Student类的属性（数据）
                1. 姓名（Name）：表示学生的姓名；
                2. 年龄（Age）：表示学生的年龄；
                3. 学号（StudentId）：表示学生的学号；
                4. 成绩（Grade）：表示学生的成绩；
            Student类的方法（行为）
                1. 学习（Study）：表示学生的学习行为；
                2. 考试（TakeExam）：表示学生的考试行为；
                3. 打印信息（PrintInfo）：打印学生的基本信息；

            创建学生对象
                然后，我们可以根据这个类创建多个学生对象：
            学生1：张三，18岁，学号001，成绩90分；
            学生2：李四，19岁，学号002，成绩85分；
            学生3：王五，20岁，学号003，成绩95分；

            每个学生对象都有自己的姓名、年龄、学号、成绩，但都遵循Student类的定义，这就是类和对象的关系。
             */

            /*
             面向对象编程有三大核心概念：
                1. 封装（Encapsulation）：把相关的数据和操作封装在一起，形成一个整体。数据和方法都在类中，外部不能直接访问，需要通过类提供的接口来访问；
                2. 继承（Inheritance）：一个类可以继承另一个类的特征和行为，子类可以继承父类的属性和方法，同时可以添加自己的新功能；
                3. 多态（Polymorphism）：同一个方法在不同的对象上可以有不同的行为。比如： Animal类的MakeSound方法，在Dog对象上叫“汪汪”，在Cat对象上叫“喵喵”；
             */

            /*
             类的组成部分：
                1. 字段（Field）：类的成员变量，用于存储对象的状态信息，通常使用小写字母开头的驼峰命名法；
                2. 属性（Property）：类的成员变量，用于存储对象的状态信息，通常使用小写字母开头的驼峰命名法；
                3. 方法（Method）：类的成员函数，用于定义对象的行为和操作，通常使用小写字母开头的驼峰命名法；
                4. 构造函数（Constructor）：用于创建对象并初始化属性值的方法，构造函数的名称与类名相同，没有返回值；
             类的语法要点：
                1. 使用关键字class来定义一个类；
                2. 类名通常使用PascalCase命名法 （大写字母开头的驼峰命名法）；
                3. 类的内容分用大括号{}包裹起来，类的成员变量和方法都定义在类的内部；
                4. 类中可以定义字段，属性，方法，构造函数等成员；
                5. 类可以有访问修饰符（public，private，protected，internal），用于控制类的可见性和访问权限；
             */

            Book book1 = new Book();    // 创建第一个Book对象
            book1.Title = "《C# Programming》";
            book1.Author = "John.Doe";
            book1.Price = 99;
            Book book2 = new Book();    // 创建第二个Book对象
            book2.Title = "《Unity Game Development》";
            book2.Author = "Jane Smith";
            book2.Price = 100;
            Book book3 = new Book();    //  创建第三个Book对象
            book3.Title = "《Python Programming》";
            book3.Author = "Alice Johnson";
            book3.Price = 89;
            Console.WriteLine($"Book 1 title is: {book1.Title} by {book1.Author}, Price: ${book1.Price}");
            Console.WriteLine($"Book 2 title is: {book2.Title} by {book2.Author}, Price: ${book2.Price}");
            Console.WriteLine($"Book 3 title is: {book3.Title} by {book3.Author}, Price: ${book3.Price}");
            Console.ReadKey();
            Console.Clear();

            Person person1 = new Person();  // 创建第一个Person对象
            person1.Name = "Sam";
            person1.Age = 25;
            person1.SayHello();
            Person person2 = new Person();  //  创建第二个Person对象
            person2.Name = "Jimmy";
            person2.Age = 22;
            person2.SayHello();
            Person person3 = new Person();  //  创建第三个Person对象
            person3.Name = "Lisa";
            person3.Age = 23;
            person3.SayHello();
            Console.ReadKey();
            Console.Clear();

            Rectangle rectangle1 = new Rectangle();
            rectangle1.ShowLengthPrompt();
            while (true)    // 循环直到用户输入有效的长度，在Main函数中负责实现与用户的交互，获取输入并进行验证，后方的类责接收和存储与计算；
            {
                if (!double.TryParse(Console.ReadLine(), out double length))
                {
                    Console.WriteLine("Invalid input.Please enter a valid number.Please re-enter the length.!");
                    continue;
                }
                else if (length <= 0)
                {
                    Console.WriteLine("Invalid input.The length cannot be 0 or negative.Please re-enter the length.!");
                    continue;
                }
                else
                {
                    rectangle1.Length = length;
                    Console.WriteLine("Length set successfully.");
                    break;
                }
            }
            rectangle1.ShowWidthPrompt();
            while (true)    // 循环直到用户输入有效的宽度，在Main函数中负责实现与用户的交互，获取输入并进行验证，后方的类责接收和存储与计算；
            {
                if (!double.TryParse(Console.ReadLine(), out double width))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.Please re-enter the width.!");
                    continue;
                }
                else if (width <= 0)
                {
                    Console.WriteLine("Invalid input.The width cannot be 0 or negative.Please re-enter the width.!");
                    continue;
                }
                else
                {
                    rectangle1.Width = width;
                    Console.WriteLine("Width set successfully.");
                    break;
                }
            }
            //rectangle1.Length = rectangle1.Length; // 触发Length属性的set访问器，进行验证
            //rectangle1.Width = rectangle1.Width;   // 触发Width属性的set访问器，进行验证
            //rectangle1.Area();
            //rectangle1.Perimeter();
            rectangle1.DisplayInfo();
            Console.ReadKey();
            Console.Clear();

            Student student1 = new Student("张三",20,"Male","S001");
            student1.Score = 98.5;
            //student1.Password = "12345";
            Console.WriteLine($"Student01:{student1.Name},Age:{student1.Age},Gender:{student1.Gender},Student ID:{student1.StudentID},Score:{student1.Score}");
            Console.ReadKey();
            Console.Clear();

            Circle circle1 = new Circle();  // 创建一个Circle对象
            Console.WriteLine("Please enter the radius of the circle:");
            while (true)    // 循环直到用户输入有效的半径，在Main函数中负责实现与用户的交互，获取输入并进行验证，后方的类责接收和存储与计算；
            {
                if (!double.TryParse(Console.ReadLine(), out double radius))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.Please re-enter the radius!");
                    continue;
                }
                else if (radius <= 0)
                {
                    Console.WriteLine("Invalid input. The radius cannot be 0 or negative.Please re-enter the radius!");
                    continue;
                }
                else
                {
                    circle1.Radius = radius;
                    Console.WriteLine($"Radius set successfully.");
                    break;
                }
            }
            Console.WriteLine($"circle1: Radius = {circle1.Radius},Area = {circle1.Area:F2},Perimeter = {circle1.Perimeter:F2}"); // 输出圆的半径、面积和周长
        }
    }
}
