using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //student
            String FirstName;
            String LastName;
            String BirthDate;
            String Address;
            String City;
            String State;
            String Zip;
            String Country;
            //professor
            String ProfessorName;
            //program
            String Degree;
            String Program;
            String DegreeHead;
            String CourseName;

            FirstName = "LiangYu";
            LastName = "Pan";
            BirthDate = "1991/07/27";
            Address = "LY Road";
            City = "New Taipei City";
            State = "Taiwan";
            Zip = "221";
            Country = "Taiwan";
            ProfessorName = "LY P";
            Degree = "Bachelor";
            Program = "Computer Science";
            DegreeHead = "L.Y.P";
            CourseName = "C#";

            Console.WriteLine("FirstName:\t" + FirstName);
            Console.WriteLine("LastName:\t" + LastName);
            Console.WriteLine("BirthDate:\t" + BirthDate);
            Console.WriteLine("Address:\t" + Address);
            Console.WriteLine("City:\t\t" + City);
            Console.WriteLine("State:\t\t" + State);
            Console.WriteLine("Zip:\t\t" + Zip);
            Console.WriteLine("Country:\t" + Country);
            Console.WriteLine("ProfessorName:\t" + ProfessorName);
            Console.WriteLine("Degree:\t\t" + Degree);
            Console.WriteLine("Program:\t" + Program);
            Console.WriteLine("DegreeHead:\t" + DegreeHead);
            Console.WriteLine("CourseName:\t" + CourseName);
        }
    }
}