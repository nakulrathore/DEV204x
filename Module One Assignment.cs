using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating Variables for Student Information
            string firstName = "NaKul";
            string lastName = "Rathore";
            DateTime birthDate = new DateTime(1993, 1, 1);
            string address1 = "2 Longview Drive";
            string address2 = "Apt. 6";
            string city = "Savannah";
            string state = "G.A.";
            int zipCode = 31405;
            string country = "U.S.";
            long contact = 1015544778;


            // creating variables for Professor information
            string pName = "Mukul Sharma";
            DateTime scince = new DateTime(1999, 7, 5);
            string pField = "Big Data";
            int age = 35;
            int booksWritten = 7;

            // creating vars for university degree
            string dtype = "Bachelor";
            string dname = "Science in I.T.";
            string credits = "None";
            int courseCount = 11;
            string courseList = "Not Available";

            // creating vars for university program
            string progName = "Computer science";
            int progCode = 781;
            string degOff = "Bachelor";
            string progHead = "Mukul Sir";

            // creating vars for Course
            string courseName = "TypeScript";
            string courseLevel = "introductory";
            string courseLang = "English";
            int lengthInMonth = 6;


            
            // printing vars for above information
            Console.WriteLine("Printing Student Information\n");
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(birthDate.ToString("d"));
            Console.WriteLine(address1);
            Console.WriteLine(address2);
            Console.WriteLine(city + " " + state + " " + country);
            Console.WriteLine(zipCode);
            Console.WriteLine(contact);


            // printing vars for Professor information
            Console.WriteLine("\n\n\nPrinting Professor Info\n");
            Console.WriteLine(pName);
            Console.WriteLine(scince);
            Console.WriteLine(pField);
            Console.WriteLine(age);
            Console.WriteLine(booksWritten);

            // printing info about degree
            Console.WriteLine("\n\n\n printing info about degree\n");
            Console.WriteLine(dtype);
            Console.WriteLine(dname);
            Console.WriteLine(credits);
            Console.WriteLine(courseCount);
            Console.WriteLine(courseList);

            // printing info of university program
            Console.WriteLine("\n\n\nPrinting university program info\n");
            Console.WriteLine(progName);
            Console.WriteLine(progCode);
            Console.WriteLine(degOff);
            Console.WriteLine(progHead);

            // printing info of Course
            Console.WriteLine("\n\n\n Printing info of Course\n");
            Console.WriteLine(courseName);
            Console.WriteLine(courseLevel);
            Console.WriteLine(courseLang);
            Console.WriteLine(lengthInMonth);


        }
    }
}
