using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C0709562
{
    class Program
    {
        static void Main(string[] args)

        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
    }

    class TestQuestion2
    {
        public int myFavVariable = 0;
        public void PlayingWithForLoops()
        {
            for (; MyMthod();)
            {
                if (myFavVariable > 10)
                {
                    Console.WriteLine("i ma so out of here");
                    break;
                }
                Console.WriteLine("i am in for loop");

            }
        }
        public bool MyMthod()
        {
            myFavVariable++;
            return true;
        }
    }
    class dog
    {
        public dog(string name, string breed)
        {
            dogName = name;
            dogbreed = breed;
        }
        public string dogName;
        public string dogbreed;
        public dog next_dog;
        public dog previous_dog;

    }
    class birthdayParty
    {
        public dog fifo;
        public dog poodle;
        public dog clarance;
        public dog roy;
        public dog germanSheppard;
        public dog head;
        public dog tail;
        public dog temporary;
    }
}
