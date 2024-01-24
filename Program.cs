using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Class_Methods
{
    internal class Program
    {
        internal class Student 
        {
            public double weight;
            public int age;
            public string name;

            public Student(double aWeight, string aName, int aAge) 
            {
              this.weight = aWeight;
                this.age = aAge;
                this.name = aName;
            }
            //Now we can test obesity for the students
            public bool IsObese()
            { 
            if (weight > 60)
                {
                    return true;
                }
                 else return false;
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim", 10);
            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());

            Console.ReadLine();

        }
    }
}
