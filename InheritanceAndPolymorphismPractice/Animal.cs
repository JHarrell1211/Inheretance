using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Animal
    {
        //fields
        private int numLegs;
        private bool vicious;
        private bool wings;
        private string color;

        //properties
        public int NumLegs
        {
            get { return this.numLegs; }
            set { this.numLegs = value; }
        }

        public bool Vicious
        {
            get { return this.vicious; }
            set { this.vicious = value; }
        }
        
        public bool Wings
        {
            get { return this.wings; }
            set { this.wings = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //Constructors
        public Animal()
        {

        }
        public Animal(int numLegs, bool vicious, bool wings, string color)
        {
            this.numLegs = numLegs;
            this.vicious = vicious;
            this.wings = wings;
            this.color = color;
        }

        //Method
        public void CanFly()
        {
            if (wings == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

    
    }
}
