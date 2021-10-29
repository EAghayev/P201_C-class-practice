using System;
using System.Collections.Generic;
using System.Text;

namespace _29102921
{
    class Student:Human
    {
        public Student(string groupNo,string name,string surname):base(name,surname)
        {
            GroupNo = groupNo;
        }


        public Student(string groupNo,int absCount,string name):base(name)
        {
            GroupNo = groupNo;
            AbsenceCount = absCount;
        }

        public string GroupNo;
        public int AbsenceCount;
        public int AbsenceLimit;

        public void SetAbsence()
        {
            this.AbsenceCount++;
        }

        public void SetAbsence(int count)
        {
            this.AbsenceCount += count;
        }

        public double GetAbsencePercent()
        {
            return (this.AbsenceCount * 100d) / this.AbsenceLimit;
        }
    }
}
