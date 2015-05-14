using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherinfo();
            Getcourseinfo();
            try
            {
                FutureFeature();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's firstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's lastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Birthday of Student");
            string birthday = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, birthday);

        }
        static void GetTeacherinfo()
        {
            Console.WriteLine("Enter the Teacher Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Teacher`s Study Field");
            string field = Console.ReadLine();
            Console.WriteLine("Enter Experience Years (in intiger Only) ");
            // this "years" varable only takes int
            int years = Convert.ToInt32(Console.ReadLine());
            PrintTeacherDeatails(name, years, field);

        }
        static void Getcourseinfo()
        {
            Console.WriteLine("Enter the Program Name");
            string program = Console.ReadLine();
            Console.WriteLine("Enter the Course Name");
            string course = Console.ReadLine();
            Console.WriteLine("Enter the Course Fee");
            string fee = Console.ReadLine();
            PrintCourseDetails(program, course, fee);
        }
        static void PrintStudentDetails(string first, string last, string birth)
        {
            Console.WriteLine(" Student \'{0} {1}\' was born on {2} \n\n\n", first, last, birth);
        }
        static void PrintTeacherDeatails(string name, int years, string field)
        {
            Console.WriteLine("\'{0}\' have \'{1}\' years of experience in \'{2}\'.\n\n\n", name, years, field);
        }
        static void PrintCourseDetails(string prog, string course, string fee)
        {
            Console.WriteLine(" \'{0}\' is in \'{1}\' course for \'{2} dollers\' ", prog, course, fee);
        }

        static void FutureFeature()
        {
            throw new NotImplementedException();
        }
    }
}
