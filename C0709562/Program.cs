using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C0707995
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
        public dog(string name, string breed, dog next, dog prev)
        {
            dogName = name;
            dogbreed = breed;
            next_dog = next;
            previous_dog = prev;
        }
        public string dogName;
        public string dogbreed;
        public dog next_dog;
        public dog previous_dog;

    }
    class birthdayParty
    {

        public dog peanut;
        public dog fifo;
        public dog clarance;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;
        public void pea()
        {
            peanut = new dog("peanut", "bichon");
            fifo = new dog("fifo", "poodle");
            clarance = new dog("clarance", "german sheppard");
            roy = new dog();
            peanut.previous_dog = null;
            peanut.next_dog = fifo;
            fifo.previous_dog = peanut;
            fifo.next_dog = clarance;
            clarance.previous_dog = fifo;
            clarance.next_dog = roy;
            clarance.previous_dog = clarance;
            clarance.next_dog = null;
            head = peanut;
            tail = roy;
        }
        public string printPartyList(dog startOfList, dog endOfList)
        {
        }
    }
}
