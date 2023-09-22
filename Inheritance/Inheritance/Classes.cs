using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal //parent class
    {

        protected string color;
        protected double weight;
        protected int age;
        protected string name;
        public Animal(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void  MakeSound()
        {
            Console.WriteLine($"{name} made a sound");
        }
        public virtual void MakeAMove()
        {
            Console.WriteLine($"{name} made a move / moved");

        }

    }
    class Dog:Animal
    {
        bool canFetch;
        public Dog(string name, int age):base(name,age)
        {
           
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{name} barks");  
        }

    }
    class Cat : Animal
    {

        bool hang;
        public Cat(string name, int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{name} meow");
        }
    }


}
