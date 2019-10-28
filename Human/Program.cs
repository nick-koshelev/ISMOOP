using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = ReadStudentsArray();
            PrintStudents(students);

        }

        static Student[] ReadStudentsArray()
        {
            Console.WriteLine("Введите количество студентов");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            int kurs;
            string group, vnz;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите курс");
                kurs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите группу");
                group = Console.ReadLine();
                Console.WriteLine("Введите название ВНЗ");
                vnz = Console.ReadLine();
                students[i] = new Student(kurs, group, vnz);
            }
            return students;
        }

        static void PrintStudent(Student obj)
        {
            Console.WriteLine("Курс: " + obj.GetKurs());
            Console.WriteLine("Группа: " + obj.GetGroup());
            Console.WriteLine("ВНЗ: " + obj.GetVNZ());
        }

        static void PrintStudents(Student[] obj)
        {
            foreach(Student ob in obj)
            {
                PrintStudent(ob);
            }
        }
    }
}
