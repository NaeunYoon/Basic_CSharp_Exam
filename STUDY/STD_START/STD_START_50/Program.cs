using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_50
{
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + " : " + Age;
        }
    }

    class SortPerson
    {
        Person[] men;

        public SortPerson(Person[] men)
        {
            this.men = men;
        }

        public void Sort()
        {
            Person tmp;

            for (int i = 0; i < men.Length; i++)
            {
                int lowPos = i;

                for (int j = i+1; j < men.Length; j++)
                {
                    if (men[j].Age < men[lowPos].Age)
                    {
                        lowPos = j;
                    }
                }
                tmp = men[lowPos];
                men[lowPos] = men[i];
                men[i] = tmp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < men.Length; i++)
            {
                Console.WriteLine(men[i]+",");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
