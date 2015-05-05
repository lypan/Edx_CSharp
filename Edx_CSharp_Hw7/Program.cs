using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_CSharp_Hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bill", "Gates", "USA");
            Student student2 = new Student("Larry", "Pages", "USA");
            Student student3 = new Student("Steve", "Jobs", "USA");

            #region studentGrade
            Random randomInstance = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomValue = 0;

                randomValue = randomInstance.Next(100);
                student1.addGrade(randomValue);

                randomValue = randomInstance.Next(100);
                student2.addGrade(randomValue);

                randomValue = randomInstance.Next(100);
                student3.addGrade(randomValue);
            }
            Console.WriteLine("");
            Console.WriteLine("Student1:");
            student1.printGrade();
            Console.WriteLine("");
            Console.WriteLine("Student2:");
            student2.printGrade();
            Console.WriteLine("");
            Console.WriteLine("Student3:");
            student3.printGrade();
            #endregion

            Course course = new Course("Programming with C#");
            course.addStudent(student1);
            course.addStudent(student2);
            course.addStudent(student3);

            Teacher teacher1 = new Teacher("LY", "P", "USA");
            course.addTeacher(teacher1);

            course.listStudents();
        }
        #region Person
        abstract public class Person
        {
            private string firstName;
            private string lastName;
            private string country;

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public string Country
            {
                get { return country; }
                set { country = value; }
            }
        }
        #endregion
        #region Student
        public class Student : Person
        {
            public static int studentNumber = 0;
            private Stack grades;
            public Student(string firstName, string lastName, string country)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Country = country;
                this.grades = new Stack();
                studentNumber++;
            }
            public void addGrade(int grade)
            {
                grades.Push(grade);
            }
            public void printGrade()
            {
                foreach (int grade in grades)
                {
                    Console.WriteLine("Grade: " + Convert.ToString(grade));
                }
            }
        }
        #endregion
        #region Teacher
        public class Teacher : Person
        {
            public Teacher(string firstName, string lastName, string country)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Country = country;
            }
        }
        #endregion
        #region Course
        public class Course
        {
            private ArrayList studentList;
            private ArrayList teacherList;
            public string courseName { get; set; }
            public Course(string courseName)
            {
                this.courseName = courseName;
                this.studentList = new ArrayList();
                this.teacherList = new ArrayList();
            }
            public void addStudent(Student student)
            {
                studentList.Add(student);
            }
            public void addTeacher(Teacher teacher)
            {
                teacherList.Add(teacher);
            }
            public void listStudents()
            {
                foreach (Student student in studentList)
                {
                    // already implicitly from object type in the studentList to Student type in the foreach(Student student in studentList) statement
                    string delimiter = ", ";
                    Console.WriteLine("First Name: " + student.FirstName + delimiter + "Last Name: " + student.LastName);
                }
            }
        }
        #endregion
    }
}