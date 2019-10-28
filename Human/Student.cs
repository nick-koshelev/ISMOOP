using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student : Enrollee
    {
        protected int Kurs;
        protected string Group;
        protected string VNZ;

        public Student()
        {

        }

        public Student(int kurs)
        {
            SetKurs(kurs);
        }

        public Student(int kurs, string group, string vnz)
        {
            SetKurs(kurs);
            SetGroup(group);
            SetVNZ(vnz);
        }

        public Student(Student obj)
        {
            Kurs = obj.Kurs;
            Group = obj.Group;
            VNZ = obj.VNZ;
        }

        public void SetKurs(int kurs)
        {
            Kurs = kurs;
        }

        public int GetKurs()
        {
            return Kurs;
        }

        public void SetGroup(string group)
        {
            Group = group;
        }

        public string GetGroup()
        {
            return Group;
        }

        public void SetVNZ(string vnz)
        {
            VNZ = vnz;
        }

        public string GetVNZ()
        {
            return VNZ;
        }
    }
}
