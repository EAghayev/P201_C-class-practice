using System;

namespace _29102921
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Lesson
            //Student student1 = new Student("P201", 3, "Tofiq");
            //Student student2 = new Student("P202", "Hikmet", "Abbasov") { };
            //Human human = new Human();

            //student2.AbsenceLimit = 23;

            //student2.SetAbsence(4);
            //student2.SetAbsence(2);

            //Console.WriteLine($"{student2.Name} absense percent: {student2.GetAbsencePercent()}");

            //Console.WriteLine(student1.GroupNo + " " + student1.AbsenceCount);
            //Console.WriteLine(student2.GetFullName() + " " + student2.GroupNo + " " + student2.AbsenceCount);

            //student2.ShowFullName();
            #endregion

            Console.WriteLine("Telebe sayini daxil edin:");
            string countStr = Console.ReadLine();

            int count = Convert.ToInt32(countStr);
            Student[] students = new Student[count];

            for (int i = 0; i < students.Length; i++)
            {
                string stdName;
                Console.WriteLine("Adini daxil edin:");
                stdName = Console.ReadLine();

                string stdSurname;
                Console.WriteLine("Soyadini daxil edin:");
                stdSurname = Console.ReadLine();

                string stdGroupNo;
                Console.WriteLine("Group nomresini daxil edin:");
                stdGroupNo = Console.ReadLine();


                string absLimitStr;
                Console.WriteLine("Qayib limitini daixl edin!");
                absLimitStr = Console.ReadLine();
                int absLimit = Convert.ToInt32(absLimitStr);

                string absCountStr;
                Console.WriteLine("Qayib sayini daxil edin!");
                absCountStr = Console.ReadLine();
                int absCount = Convert.ToInt32(absCountStr);

                Student std = new Student(stdGroupNo, stdName, stdSurname);
                std.AbsenceLimit = absLimit;
                std.AbsenceCount = absCount;

                students[i] = std;
            }

            string answer;
            do
            {
                Console.WriteLine("Limite gore filtilemek isteyirisnizmi? y/n");
                answer = Console.ReadLine();

            } while (answer!="y" && answer!="n");


            if(answer == "y")
            {
                Console.WriteLine("Minimum qayib sayini daxil edin:");
                string minAbsCountStr = Console.ReadLine();
                int minAbsCount = Convert.ToInt32(minAbsCountStr);

                Console.WriteLine("Maximum qayib sayini daxil edin:");
                string maxAbsCountStr = Console.ReadLine();
                int maxAbsCount = Convert.ToInt32(maxAbsCountStr);

                var filteredStudents = GetFilteredStudents(students, minAbsCount, maxAbsCount);
                Console.WriteLine("Filtirlenmis telebelerin siyahisi:");
                foreach (var std in filteredStudents)
                {
                    Console.WriteLine($"{std.GetFullName()} qayib sayi: {std.AbsenceCount} qayib faizi: {std.GetAbsencePercent()}");
                }
            }
            else
            {
                Console.WriteLine("Telebelerin siyahisi:");
                foreach (var std in students)
                {
                    Console.WriteLine($"{std.GetFullName()} qayib sayi: {std.AbsenceCount} qayib faizi: {std.GetAbsencePercent()}");
                }
            }
           


        }


        static Student[] GetFilteredStudents(Student[] students,int minAbsCount,int maxAbsCount)
        {
            int count = 0;
            foreach (var std in students)
            {
                if (std.AbsenceCount >= minAbsCount && std.AbsenceCount <= maxAbsCount) count++;
            }

            Student[] filteredStundets = new Student[count];

            int index = 0;
            foreach (var std in students)
            {
                if (std.AbsenceCount >= minAbsCount && std.AbsenceCount <= maxAbsCount)
                {
                    filteredStundets[index] = std;
                    index++;
                }
            }

            return filteredStundets;
        }
    }
}
