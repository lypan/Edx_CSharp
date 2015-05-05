using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_CSharp_Hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bill", "Gates", "USA");
            Student student2 = new Student("Larry", "Pages", "USA");
            Student student3 = new Student("Steve", "Jobs", "USA");

            Course course = new Course("Programming with C#");
            course.addStudent(student1, 0);
            course.addStudent(student2, 1);
            course.addStudent(student3, 2);

            Teacher teacher1 = new Teacher("LY", "P", "USA");
            course.addTeacher(teacher1, 0);

            Degree degree = new Degree("Bachelor of Science degree");
            degree.addCourse(course);

            UProgram uprogram = new UProgram("Information Technology");
            uprogram.addDegree(degree);
            uprogram.display();
        }
    }
    #region Student
    public class Student
    {
        //property
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string country { get; set; }
        public static int studentNumber = 0;
        //constructor
        public Student(string firstName, string lastName, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
            studentNumber++;
        }
    }
    #endregion
    #region Teacher
    public class Teacher
    {
        //property
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string country { get; set; }
        //constructor
        public Teacher(string firstName, string lastName, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
        }
    }
    #endregion
    #region Course
    public class Course
    {
        private Student[] studentArray;
        private Teacher[] teacherArray;
        private string[] test;
        public string courseName { get; set; }
        public Course(string courseName)
        {
            this.courseName = courseName;
            this.studentArray = new Student[3];
            this.teacherArray = new Teacher[3];
        }
        public void addStudent(Student student, int index)
        {
            studentArray[index] = student;
        }
        public void addTeacher(Teacher teacher, int index)
        {
            teacherArray[index] = teacher;
        }
    }
    #endregion
    #region Degree
    public class Degree
    {
        public Course course { get; set; }
        public string degreeName { get; set; }
        public Degree(string degreeName)
        {
            this.degreeName = degreeName;
        }
        public void addCourse(Course course)
        {
            this.course = course;
        }
    }
    #endregion
    #region UProgram
    public class UProgram
    {
        public Degree degree { get; set; }
        public string UProgramName { get; set; }
        public UProgram(string UProgramName)
        {
            this.UProgramName = UProgramName;
        }
        public void addDegree(Degree degree)
        {
            this.degree = degree;
        }
        public void display()
        {
            string studentNumberString = Convert.ToString(Student.studentNumber);
            Console.WriteLine("The " + UProgramName + " program contains the " + degree.degreeName);
            Console.WriteLine("The " + degree.degreeName + " contains the " + degree.course.courseName);
            Console.WriteLine("The " + degree.course.courseName + " course contains " + studentNumberString + " students");
        }
    }
    #endregion
}