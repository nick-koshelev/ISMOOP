using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Libruar : Human
    {
        protected int Number;
        protected int LYear;
        protected int LMonth;
        protected int LDay;
        protected int Contribution;

        public Libruar()
        {

        }

        public Libruar(int number)
        {
            SetNumber(number);
        }

        public Libruar(int number, int lyear, int lmonth, int lday, int contribution)
        {
            SetNumber(number);
            SetLYear(lyear);
            SetLMonth(lmonth);
            SetLDay(lday);
            SetContribution(contribution);
        }

        public Libruar(Libruar obj)
        {
            Number = obj.Number;
            LYear = obj.Year;
            LMonth = obj.LMonth;
            LDay = obj.LDay;
            Contribution = obj.Contribution;
        }

        public void SetNumber(int number)
        {
            Number = number;
        }

        public int GetNumber()
        {
            return Number;
        }

        public void SetLYear(int year)
        {
            LYear = year;
        }

        public int GetLYear()
        {
            return Year;
        }

        public void SetLMonth(int month)
        {
            LMonth = month;
        }

        public int GetLMonth()
        {
            return LMonth;
        }

        public void SetLDay(int day)
        {
            LDay = day;
        }

        public int GetLDay()
        {
            return LDay;
        }

        public void SetContribution(int contribution)
        {
            Contribution = contribution;
        }

        public int GetContribution()
        {
            return Contribution;
        }
    }
}
