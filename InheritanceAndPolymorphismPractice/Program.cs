using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pete = new Dog("pit bull", "large");
            Console.WriteLine("Is pete a guard dog? ");
            pete.GuardDog();

            pete.Vicious = false;
            pete.GuardDog();
            


        }
    }
}
