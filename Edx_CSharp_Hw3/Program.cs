using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_CSharp_Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();

            try
            {
                validateStudentBirthday();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday(ex:2222/02/22)");
            string birthday = Console.ReadLine();
            Console.WriteLine("Enter the student's department(ex:CS)");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the student's degree(ex:undergraduate/graduate)");
            string degree = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, birthday, department, degree);
        }

        static void PrintStudentDetails(string first, string last, string birthday, string department, string degree)
        {
            Console.WriteLine("{0} {1} was born on {2}", first, last, birthday);
            Console.WriteLine("{0} {1} is a {2} student in {3} department", first, last, degree, department);
        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's course");
            string course = Console.ReadLine();
            Console.WriteLine("Enter the teacher's program");
            string program = Console.ReadLine();
            Console.WriteLine("Enter the teacher's degree");
            string degree = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, course, program, degree);
        }
        static void PrintTeacherDetails(string first, string last, string course, string program, string degree)
        {
            Console.WriteLine("{0} {1} teaches {2}", first, last, course);
            Console.WriteLine("{0} {1} is a {2} in {3} program", first, last, degree, program);
        }
        static void validateStudentBirthday()
        {
            // Not developed yet.
            throw new NotImplementedException();
        }
    }
}

