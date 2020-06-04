using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            string[] inputFile = File.ReadAllLines(fileName);
            Student[] studData = new Student[inputFile.Length];

            for (int i = 0; i < inputFile.Length; i++)
            {
                studData[i] = new Student(inputFile[i]);
            }
            return studData;
        }

        static void runMenu(Student[] studs)
        {
            Console.WriteLine("Студенти, що мають незадовільну оцінку або неявку: ");
            for (int i = 0; i < studs.Length; i++)
            {
                if ((studs[i].mathematicsMark == '2' || studs[i].mathematicsMark == '-' || studs[i].physicsMark == '2' || studs[i].physicsMark == '-' || studs[i].informaticsMark == '2' || studs[i].informaticsMark == '-'))
                {
                    studs[i].scholarship = 0;
                    Console.WriteLine("{0} {1} {2} {3}", studs[i].surName, studs[i].mathematicsMark, studs[i].physicsMark, studs[i].informaticsMark);
                }
                using (StreamWriter SW = File.AppendText("data_new.txt"))
                {
                    SW.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}  {8}", studs[i].surName, studs[i].firstName, studs[i].patronymic, studs[i].sex, studs[i].dateOfBirth, studs[i].mathematicsMark, studs[i].physicsMark, studs[i].informaticsMark, studs[i].scholarship);
                }
            }
        }

        static void Main(string[] args)
        {
            string path = @"input.txt";
            Student[] studs = ReadData(path);
            runMenu(studs);
            Console.ReadKey();
        }
    }
}
