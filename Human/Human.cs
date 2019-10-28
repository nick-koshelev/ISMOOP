using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {
        protected string Name;
        protected string Vorname;
        protected int Year;
        protected int Month;
        protected int Day;

        public Human()
        {

        }

        public Human(string name, string vorname)
        {
            SetName(name);
            SetVorname(vorname);
        }

        public Human(string name, string vorname, int year, int month, int day) 
        {
            SetName(name);
            SetVorname(vorname);
            SetYear(year);
            SetMonth(month);
            SetDay(day);
        }

        public Human(Human obj)
        {
            Name = obj.Name;
            Vorname = obj.Vorname;
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetVorname(string vorname)
        {
            Vorname = vorname;
        }
        
        public string GetVorname()
        {
            return Vorname;
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

        public void SetDay(int day)
        {
            Day = day;
        }

        public int GetDay()
        {
            return Day;
        }
    }

    
}
