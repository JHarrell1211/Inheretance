using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Dog : Animal
    {
        private string dogType;
        private string size;

        public string DogType
        {
            get { return this.dogType; }
            set { this.dogType = value; }
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        // this default dog would have the base properties set as default from Animal
        public Dog(): base(4,true,false,"black")
        {
            
        }
        // this base is not needed but can be used to set default values of constructor from Animal
        public Dog(string dogType, string size) :  base(4, true, false, "brown")
        {
            this.dogType = dogType;
            this.size = size;
        }

        public void GuardDog()
        {
            if (size == "large" && Vicious == true)
            {
                Console.WriteLine("yes");
            }
            else if (size == "medium" && Vicious == true)
            {
                Console.WriteLine("maybe");
            }
            else
            {
                Console.WriteLine("no");
            }
        }


    }
}
