using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_CSharp_Hw4
{

    struct ProgramS
    {
        public string programName;
        public ProgramS(string programName)
        {
            this.programName = programName;
        }

    }
    struct Course
    {
        public string courseName;
        public Course(string courseName)
        {
            this.courseName = courseName;
        }
    }
    struct Teacher
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public string degree;
        public Teacher(string firstName, string lastName, string birthday, string degree)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.degree = degree;
        }
    }
    struct Student
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public string degree;
        public ProgramS program;
        public Student(string firstName, string lastName, string birthday, string degree, ProgramS program)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.degree = degree;
            this.program = program;
        }
        public void display()
        {
            Console.WriteLine("Student who called {0} {1} is born in {2}  a {3} in {4}", firstName, lastName, birthday, degree, program.programName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("C sharp");
            ProgramS program = new ProgramS("Computer Science");
            Teacher teacher = new Teacher("John","Cena","1977/04/23","World Champion");
            Student[] studentArray = new Student[5];
            studentArray[0] = new Student("Bill","Gates","1955/10/28","CEO",program);
            studentArray[0].display();
        }
    }
}
