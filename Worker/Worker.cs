using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int Year;
        protected int Month;
        protected Company WorkPlace;

        public Worker()
        {

        }

        public Worker(string name, int year)
        {
            SetName(name);
            SetYear(year);
        }

        public Worker(string name, int year, int month, string companyName, string position, int salary)
        {
            SetName(name);
            SetYear(year);
            SetMonth(month);
            WorkPlace = new Company(companyName, position, salary);
        }

        public Worker(Worker obj)
        {
            Name = obj.Name;
            Year = obj.Year;
            Month = obj.Month;
            WorkPlace = obj.WorkPlace;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public int GetYear()
        {
            return Year;
        }

        public void SetMonth(int month)
        {
            Month = month;
        }

        public int GetMonth()
        {
            return Month;
        }

        public void SetCompany(Company workPlace)
        {
            WorkPlace = workPlace;
        }

        public Company GetCompany()
        {
            return WorkPlace;
        }
        
        public int GetWorkExperience()
        {
            int ex = (DateTime.Now.Year - 1 - Year) * 12;
            if (DateTime.Now.Month <= Month)
            {
                ex = ex + DateTime.Now.Month + 12 - Month;
            }
            else
            {
                ex = ex + DateTime.Now.Month - Month;
            }
            return ex;
        }

        public int GetTotalMoney()
        {
            int salary = WorkPlace.GetSalary();
            int total = GetWorkExperience() * salary;
            return total;
        }
    }
}
