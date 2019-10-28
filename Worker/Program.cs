using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSalary, minSalary;
            Worker[] workers = ReadWorkersArray();
            PrintWorkers(workers);
            GetWorkersInfo(workers, out maxSalary, out minSalary);
            SortWorkerBySalary(workers);
        }

        static Worker[] ReadWorkersArray()
        {
            int n;
            Console.WriteLine("Введите количество рабочих");
            n = Convert.ToInt32(Console.ReadLine());
            Worker[] worker = new Worker[n];
            for (int i = 0; i < n; i++)
            {
                int year, month, salary;
                string workerName, companyName, position;
                Console.WriteLine("Введите название компании");
                companyName = Console.ReadLine();
                Console.WriteLine("Введите имя рабочего");
                workerName = Console.ReadLine();
                Console.WriteLine("Введите должность рабочего");
                position = Console.ReadLine();
                Console.WriteLine("Введите год начала работы");
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Неверный год\nПовторите попытку");
                }
                Console.WriteLine("Введите месяц начала работы");
                while (!int.TryParse(Console.ReadLine(), out month))
                {
                    Console.WriteLine("Месяц введён неверно\nПовторите попытку");
                }
                Console.WriteLine("Введите зарплату рабочего");
                while (!int.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Зарплата введена неверно/nПовторите попытку");
                }
                worker[i] = new Worker(workerName, year, month, companyName, position, salary);
            }
            return worker;
        }

        static void PrintWorker(Worker obj)
        {
            Console.WriteLine("Название компании: " + obj.GetCompany().GetName());
            Console.WriteLine("Имя рабочего: " + obj.GetName());
            Console.WriteLine("Должность рабочего: " + obj.GetCompany().GetPosition());
            Console.WriteLine("Год начала работы: " + obj.GetYear());
            Console.WriteLine("Месяц начала работы: " + obj.GetMonth());
            Console.WriteLine("Зарплата рабочего: " + obj.GetCompany().GetSalary());
        }

        static void PrintWorkers(Worker[] obj)
        {
            foreach(Worker ob in obj)
            {
                PrintWorker(ob);
            }
        }

        static void GetWorkersInfo(Worker[] obj, out int maxSalary, out int minSalary)
        {
            obj = SortWorkerBySalary(obj);
            maxSalary = obj[0].GetCompany().GetSalary();
            minSalary = obj[obj.Length - 1].GetCompany().GetSalary();
            Console.WriteLine("Максимальная зарлата: " + maxSalary);
            Console.WriteLine("Минимальная зарплата: " + minSalary);
        }
        
        static Worker[] SortWorkerBySalary(Worker[] obj)
        {
            int l = 0;
            for(int i = 0; l != 1; i++)
            {
                l = 1;
                for (int j = 0; j < obj.Length - 1; j++)
                {
                    if (obj[j].GetCompany().GetSalary() < obj[j + 1].GetCompany().GetSalary())
                    {
                        Worker temp = new Worker(obj[j]);
                        obj[j] = new Worker(obj[j + 1]);
                        obj[j + 1] = new Worker(temp);
                        l = 0;
                    }
                }
            }
            return obj;
        }

        static void SortWorkerByWorkExperience(Worker[] obj)
        {
            int l = 0;
            for(int i = 0; l != 1; i++)
            {
                l = 1;
                if(obj[i].GetWorkExperience() > obj[i + 1].GetWorkExperience())
                {
                    Worker temp = new Worker(obj[i]);
                    obj[i] = new Worker(obj[i + 1]);
                    obj[i + 1] = new Worker(obj[i + 1]);
                    l = 0;
                }
            }
        }
    }
}
