using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Bird : Animal
    {
        private string birdType;
        private bool migrates;

        public string BirdType
        {
            get { return this.birdType; }
            set { this.birdType = value; }
        }

        public bool Migrates
        {
            get { return this.migrates; }
            set { this.migrates = value; }
        }

        public Bird()
        {
            //If we call this Bird constructor, wings is always set to false
            this.Wings = false;
        }
        public Bird(string birdType, bool migrates) : base(2, false, true, "red")
        {
            this.birdType = birdType;
            this.migrates = migrates;
        }


    }
}
