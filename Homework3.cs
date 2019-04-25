using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkList
{
    class Student
    {
        public string name;
        public int[] marks = new int[3];
        public int total;
        public int average;
    }
    class CStudents
    {
        public List<Student> m_studList = new List<Student>();
        public int m_nMaxStudents;

        public int AddRecord(string name, int[] marks)
        {
            Student stud = new Student();
            stud.name = name;
            stud.marks = marks;
            stud.total = 0;
            stud.average = 0;
            for (int i = 0; i < 3; i++)
            {
                stud.total += stud.marks[i];
                stud.average = stud.total / 3;
            }
            m_studList.Add(stud);
            m_nMaxStudents = m_studList.Count;
            return 1;
        }
            class Program
        {
            static public CStudents theStudents = new CStudents();
            static public void ViewRecords()
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("No Student Name       Sub1   Sub2   Sub3   Total   Average");
                Console.WriteLine("__________________________________________________________");

                for (int i = 0; i < theStudents.m_nMaxStudents; i++)
                {
                    Console.Write("{0, -5}", i + 1);
                    Console.Write("{0, -19}", theStudents.m_studList[i].name);
                    Console.Write("{0, -7}", theStudents.m_studList[i].marks[0]);
                    Console.Write("{0, -7}", theStudents.m_studList[i].marks[1]);
                    Console.Write("{0, -7}", theStudents.m_studList[i].marks[2]);
                    Console.Write("{0, -7}", theStudents.m_studList[i].total);
                    Console.Write("{0, -7}", theStudents.m_studList[i].average);
                    Console.WriteLine();
                }
                    Console.WriteLine("__________________________________________________________");
                    Console.WriteLine("AverageByDiscipline");
            }

            static public void InputRecords()
            {
                Console.Write("Student Name: ");
                string name;
                int[] marks = new int[3];
                name = Console.ReadLine();
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Sub " + i.ToString() + " Mark: ");
                    marks[i - 1] = Convert.ToInt32(Console.ReadLine());
                }
                theStudents.AddRecord(name, marks);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Student MarkList");
                Console.Write("Enter the number of students in Group: ");
                int numStudents = -1;
                string s = Console.ReadLine();
                numStudents = Convert.ToInt32(s);
                for (int i = 1; i <= numStudents; i++)
                {
                    Console.WriteLine("\nEnter " + i.ToString() + " Student Information\n");
                    InputRecords();
                }
                ViewRecords();
                char ch = Console.ReadKey().KeyChar;
            }
        }
    }
}
