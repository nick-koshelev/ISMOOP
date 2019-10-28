using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Teacher : Human
    {
        protected string Position;
        protected string Department;
        protected string TVNZ;

        public Teacher()
        {

        }

        public Teacher(string position)
        {
            SetPosition(position);
        }

        public Teacher(string position, string department, string vnz)
        {
            SetPosition(position);
            SetDepartment(department);
            SetTVNZ(vnz);
        }

        public Teacher(Teacher obj)
        {
            Position = obj.Position;
            Department = obj.Department;
            TVNZ = obj.TVNZ;
        }

        public void SetPosition(string position)
        {
            Position = position;
        }

        public string GetPosition()
        {
            return Position;
        }

        public void SetDepartment(string department)
        {
            Department = department;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public void SetTVNZ(string tvnz)
        {
            TVNZ = tvnz;
        }

        public string GetTVNZ()
        {
            return TVNZ;
        }
    }
}
