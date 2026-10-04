using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _11_ClassPractice
{
    public class Student
    {
        // 自动属性（Auto-Implemented Property）：C#提供了一种简化属性定义的方式，称为自动属性。自动属性允许我们在不显式定义字段的情况下，快速创建属性。编译器会自动生成一个私有的匿名字段来存储属性的值。
        public string Name { get; set; }
        public int Age { get; set; }

        // 带验证的属性（Property with Validation）：我们可以在属性的set访问器中添加验证逻辑，以确保属性值的有效性。例如，我们可以限制性别只能是"Male"或"Female"。
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "Male" || value == "Female")
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Invalid gender. Please enter 'Male' or 'Female'.");
                }
            }
        }
        private double score;
        public double Score
        {
            get { return score;}
            set
            {
                if (value <= 0)
                {
                    score = 0;
                }
                else if (value >= 100)
                {
                    score = 100;
                }
                else
                {
                    score = value;
                }
            }
        }

        // 只读属性（Read-Only Property）：我们可以创建只读属性，只提供get访问器而不提供set访问器，从而使属性值只能在类内部设置，而外部只能读取。例如，我们可以创建一个只读的学生ID属性。
        private string studentID;
        public string StudentID
        {
            get { return studentID; }
        }

        // 只能写属性（Write-Only Property）：我们可以创建只能写的属性，只提供set访问器而不提供get访问器，从而使属性值只能在类外部设置，而不能读取。例如，我们可以创建一个只能写的密码属性。
        private string password;
        public string Password
        {
            set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password must be at least 6 characters long.");
                }
            }
        }

        // 构造函数（Constructor）：构造函数是一种特殊的方法，用于在创建对象时初始化对象的状态。构造函数的名称与类名相同，并且没有返回类型。我们可以在构造函数中为属性赋初始值。
        public Student(string name,int age,string gender,string studentID)
        {
            Name = name;
            Age = age;
            Gender = gender;
            this.studentID = studentID;
        }

        // 属性与字段的选择：
        /*
         何时使用字段：
            私有字段 只在类内部使用，通常用于存储数据。不需要外部访问；
            简单数据 不需要验证或额外逻辑的数据；

        何时使用属性：
            公共接口 需要外部访问的成员，通常使用属性来提供访问接口；
            需要验证 需要在赋值时验证数据；
            需要计算 需要返回计算后的值；
            需要访问控制 需要控制读写权限；

        最佳实践：
            尽量使用属性而不是公共字段，以便在将来需要添加验证或逻辑时不会破坏现有代码；
            使用自动属性简化代码，但在需要验证或逻辑时使用完整的属性定义；
            保持字段为私有，提供公共属性作为访问接口。
            对外暴露用属性，内部可用字段；
            不要验证时优先使用自动属性，若需要验证则手动写set控制验证；
         */
    }
}
