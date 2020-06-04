using System;
using System.Text;
using System.Linq;

namespace struct_lab_student
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] dataOfOneStud = lineWithAllData.Split(' ');

            surName = dataOfOneStud[0];
            firstName = dataOfOneStud[1];
            patronymic = dataOfOneStud[2];
            sex = Convert.ToChar(dataOfOneStud[3]);
            dateOfBirth = dataOfOneStud[4];
            mathematicsMark = Convert.ToChar(dataOfOneStud[5]);
            physicsMark = Convert.ToChar(dataOfOneStud[6]);
            informaticsMark = Convert.ToChar(dataOfOneStud[7]);
            scholarship = Convert.ToInt32(dataOfOneStud[8]);
        }
    }
}
