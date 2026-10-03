using System;
using System.Collections.Generic;
using System.Text;

namespace _11_ClassPractice
{
    public class Rectangle
    {
        private double length;  // 私有字段，外部无法直接访问    长
        public double Length    // 公有属性，提供对私有字段的访问
        {
            get { return length; }  // 访问器（Getter）用于获取私有字段的值
            set // 设置器（Setter）用于设置私有字段的值，并进行验证
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("The length cannot be 0 or negative!");
                }
                //while (true)
                //{
                //    if (!double.TryParse(Console.ReadLine(), out double lengthValue))
                //    {
                //        Console.WriteLine("Invalid input. Please enter a valid number.Please re-enter the length.!");
                //    }
                //    else if (lengthValue <= 0)
                //    {
                //        Console.WriteLine("Invalid input. The length cannot be 0 or negative.Please re-enter the length.!");
                //    }
                //    else
                //    {
                //        length = lengthValue;
                //        Console.WriteLine("Length set successfully.");
                //        break;
                //    }
                //}
            }
        }
        private double width;   // 宽
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("The width cannot be 0 or negative!");
                }
                //while (true)
                //{
                //    if (!double.TryParse(Console.ReadLine(), out double widthValue))
                //    {
                //        Console.WriteLine("Invalid input. Please enter a valid number.Please re-enter the width.!");
                //    }
                //    else if (widthValue <= 0)
                //    {
                //        Console.WriteLine("Invalid input.The width cannot be 0 or negative.Please re-enter the width.!");
                //    }
                //    else
                //    {
                //        width = widthValue;
                //        Console.WriteLine("Width set successfully.");
                //        break;
                //    }
                //}
            }
        }
        //public double Area  // 只读属性，外部无法修改其值，只能读取其值（计算面积）
        //{
        //    get
        //    {
        //        return length * width;
        //    }
        //}
        //public double Perimeter // 只读属性，外部无法修改其值，只能读取其值（计算周长）
        //{
        //    get
        //    {
        //        return 2 * (length + width);
        //    }
        //}
        public void ShowLengthPrompt()
        {
            Console.WriteLine("Please input the length of the rectangle:");
        }
        public void ShowWidthPrompt()
        {
            Console.WriteLine("Please input the width of the rectangle:");
            
        }
        public double Area()  // 方法（Method）是类的成员函数，用于定义对象的行为和操作（方法名用大驼峰命名法）
        {
            return length * width;
        }
        public double Perimeter()  // 方法（Method）是类的成员函数，用于定义对象的行为和操作（方法名用大驼峰命名法）
        {
            return 2 * (length + width);
        }
        public void DisplayInfo()  // 方法（Method）是类的成员函数，用于定义对象的行为和操作（方法名用大驼峰命名法）
        {
            Console.WriteLine($"Rectangle: Length = {length}, Width = {width}, Area = {Area()}, Perimeter = {Perimeter()}");
        }
    }
}
