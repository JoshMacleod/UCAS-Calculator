using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAS_Calculator
{
    class Program
    {
        struct Pupil
        {
            public int ID;
            public string name;
            public char gender;
            public DateTime dateOfBirth;
            public string address;
        }
        struct Subject
        {
            public string title;
            public string level;
        }
        enum UCASGrades
        {
            A = 120, B = 100, C = 80, D = 60, E = 40
        }
        static void Main(string[] args)
        {
            Initialise();
        }
        static void Initialise()
        {
            List<Pupil> pupils = new List<Pupil>();
            List<Subject> subjects = new List<Subject>();
        }
        static void addDetails()
        {
            
        }
        static void getDetails()
        {

        }
        static void Calculate()
        {

        }
    }
}
