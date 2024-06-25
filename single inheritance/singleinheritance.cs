using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance
{

    public class Animal

    {
        public void eat() { Console.WriteLine("Eating..."); }

    }

    public class Dog : Animal

    {
        public void bark() { Console.WriteLine("Barking..."); }

    }

    public class singleinheritance
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();

            d1.eat();

            d1.bark();
            Console.ReadKey();
        }
    }
}
