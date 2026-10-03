using System;
using System.Collections.Generic;
using System.Text;

namespace _11_ClassPractice
{
    public class Person
    {
        public string name;     // 字段（Field）是类的成员变量，用于存储对象的状态信息
        public int age;
        public string gender;
        private string studentID; // 私有字段，外部无法直接访问（字段名用小驼峰命名法）
        public string StudentID   // 公有属性，提供对私有字段的访问（属性名用大驼峰命名法）
        {
            get // 访问器（Getter）用于获取私有字段的值
            {
                return studentID;
            }
            set // 设置器（Setter）用于设置私有字段的值
            {
                studentID = value;
            }
        }
        public void SayHello()  // 方法（Method）是类的成员函数，用于定义对象的行为和操作（方法名用大驼峰命名法）
        {
            Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and I am a {gender}.");
        }

        /*
         只读属性只有get访问器，没有set访问器，外部无法修改其值，只能读取其值，只能通过构造函数或类内部的方法来初始化赋值。例如：
        class Car
        {
            private string carID;
            public string CarID     // 只读属性，外部无法修改其值
            {
                get {return carID;}
            }
            public Car(string carID)    // 构造函数用于初始化只读属性的值
            {
                this.carID = carID;
            }
        }
         */

        /*
         只写属性只有set访问器，没有get访问器，外部无法读取其值，只能修改其值，只能通过类内部的方法来获取其值。例如：password；
        class Person
        {
            private string password;
            public string Password
            {
                set { password = value; }  // 只写属性，外部无法读取其值
            }
        }
         */

        /*
         自动属性（Auto-Implemented Property）是C#提供的一种简化属性定义的方式，编译器会自动生成一个私有的匿名字段来存储属性的值，无需手写字段和访问器。例如：
        class Car
        {
            public string CarColor { get; set; } = "Red"; // 可以设置默认初始值
            public int CarSpeed{ get; set; } = 0; // 可以设置默认初始值
        }
         */

        // 在不需要验证输入的情况下，优先使用自动属性; 如果需要验证输入或其他逻辑处理，则使用手写字段和手动编写的属性。
    }
}
