using System;
using System.Collections.Generic;
using System.Text;

namespace _11_ClassPractice
{
    public class Circle
    {
        public double Radius { get; set; } // 自动属性（Auto-Implemented Property）
        public double Area  // 只读属性（Read-Only Property）计算圆的面积，公式为：面积 = π * 半径²
        {
            get { return 3.14 * Radius * Radius; } // 只读属性（Read-Only Property）}
            //get { return  Math.PI* Radius * Radius; } // 只读属性（Read-Only Property）}
        }
        public double Perimeter   // 只读属性（Read-Only Property）计算圆的周长，公式为：周长 = 2 * π * 半径
        {
            get { return 2 * 3.14 * Radius; } // 只读属性（Read-Only Property）}
            //get { return 2 * Math.PI * Radius; } // 只读属性（Read-Only Property）    
        }
    }
}
