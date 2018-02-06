using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Shape
    {
        //fields
        private int sides;


        //Properties
        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        //Constructors
        public Shape()
        {

        }
        public Shape(int sides)
        {
            this.sides = sides;
        }

        //Methods

    }
}
