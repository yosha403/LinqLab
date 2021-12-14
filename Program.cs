using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 10, 2330, 112233, 10, 949, 3764, 2942 };
            Console.WriteLine("Numbers are: ");
            foreach(int n in nums)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int minValue = nums.Min();
            Console.WriteLine("1) Minimum Value: "+minValue);

            int maxValue = nums.Max();
            Console.WriteLine("2) Maximum Value: " + maxValue);

            int maxLessThan10000 = nums.Where(n => n<=10000).Max();
            Console.WriteLine("3) Maximum value less than 10000: "+ maxLessThan10000);

            List<int> values = nums.Where(n => n>10 && n<100).ToList();
            Console.WriteLine("4) Values between 10 and 100: ");
            foreach(int value in values)
            {
                Console.WriteLine(value);
            }

            List<int> newValues = nums.Where(n => n >= 100000 && n <= 999999).ToList();
            Console.Write ("5) Values between 100000 and 999999: ");
            foreach (int value in newValues)
            {
                Console.Write(value+ " ");
            }

            int evenNumberCount = nums.Count(n => n % 2 == 0);
            Console.WriteLine("6) Count all the even numbers: "+ evenNumberCount);

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));
            Console.WriteLine();
            List<Student> studentsOver21 = students.Where(x => x.Age>=21).ToList();
            Console.WriteLine("1) Students age of 21 and over: ");
            foreach(Student s in studentsOver21)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            int oldStudentAge = students.Max(x => x.Age);
            List<Student> oldestStudent = students.Where(x => x.Age == oldStudentAge).ToList();
            foreach (Student s in oldestStudent)
            {
                Console.WriteLine("2) Oldest student: "+s.Name);
            }
            Console.WriteLine();
            int youngStudentAge = students.Min(x => x.Age);
            List<Student> youngestStudent = students.Where(x => x.Age == youngStudentAge).ToList();
            foreach (Student s in youngestStudent)
            {
                Console.WriteLine("3) Youngest student: " + s.Name);
            }
            Console.WriteLine();

            List<Student> oldUnder25 = students.Where(x => x.Age < 25).ToList().ToList();
            int oldAgeUnder25 = oldUnder25.Max(x=>x.Age);
            Console.WriteLine("4) Oldest student under the age of 25: ");
            List<Student> studentUnder25 = students.Where(x => x.Age== oldAgeUnder25).ToList();
            foreach (Student s in studentUnder25)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            List<Student> stuOver21 = students.Where(x => x.Age > 21 && x.Age %2==0).ToList();
            Console.WriteLine("5) All students over 21 and with even ages: ");
            foreach (Student s in stuOver21)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            List<Student> teenageStudents = students.Where(x => x.Age >= 13 && x.Age <=19).ToList();
            Console.WriteLine("6) All teenage students: ");
            foreach (Student s in teenageStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            List<string> prefixList = new List<string>() { "A", "E", "I", "O", "U"};
            List<Student> nameStartWithVowel = students.Where(x => prefixList.Any(p => x.Name.StartsWith(p))).ToList();
            Console.WriteLine("7) Students whose name starts with a vowel: ");
            foreach (Student s in nameStartWithVowel)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
