using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string Name;
        protected string Position;
        protected int Salary;

        public Company()
        {

        }

        public Company(string name, string position)
        {
            SetName(name);
            SetPosition(position);
        }

        public Company(string name, string position, int salary)
        {
            SetName(name);
            SetPosition(position);
            SetSalary(salary);
        }

        public Company(Company obj)
        {
            Name = obj.Name;
            Position = obj.Position;
            Salary = obj.Salary;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string position)
        {
            Position = position;
        }

        public string GetPosition()
        {
            return Position;
        }

        public void SetSalary(int salary)
        {
            Salary = salary;
        }

        public int GetSalary()
        {
            return Salary;
        }
    }
}
