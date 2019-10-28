using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Enrollee : Human
    {
        protected int ZNOPoint;
        protected int EducPoint;
        protected string SchoolName;

        public Enrollee()
        {

        }

        public Enrollee(int znopoint, int educpoint)
        {
            SetZNOPoint(znopoint);
            SetEducPoint(educpoint);
        }

        public Enrollee(int znopoint, int educpoint, string schoolname)
        {
            SetZNOPoint(znopoint);
            SetEducPoint(educpoint);
            SetSchoolName(schoolname);
        }

        public Enrollee(Enrollee obj)
        {
            ZNOPoint = obj.ZNOPoint;
            EducPoint = obj.EducPoint;
            SchoolName = obj.SchoolName;
        }

        public void SetZNOPoint(int znopoint)
        {
            ZNOPoint = znopoint;
        }

        public int GetZNOPoint()
        {
            return ZNOPoint;
        }

        public void SetEducPoint(int educpoint)
        {
            EducPoint = educpoint;
        }

        public int GetEducPoint()
        {
            return EducPoint;
        }

        public void SetSchoolName(string schoolname)
        {
            SchoolName = schoolname;
        }

        public string GetScholName()
        {
            return SchoolName;
        }
    }
}
