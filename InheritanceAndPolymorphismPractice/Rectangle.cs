using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    //Derived Class
    public class Rectangle : Shape
    {
        private double area;

        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }

        //A derived class does NOT inherit the constructors of the base class. However, the constructors
        // of the base class can bee accesed using the "base" keyword.

        public Rectangle (double area) : base(4) // 4  correlates with the Shape class with argument for sides
        {
            this.area = area;
        }

    }
}
