using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Individual_Project_1
{
    public class Student
    {
        public int IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get { return $"{FirstName} {LastName}"; } 
        }
        public DateOnly DOB { get; set; }
        public string DOBString {
            get { return DOB.ToString("yyyy MMMM dd"); }
        }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public double GPA { get; set; }
        public string? Charactor {
            get { return FirstName[0].ToString().ToUpper() + LastName[0].ToString().ToUpper(); }  
        }
        public string BGColorString { get; set; }
        public Brush BGColor { 
            get {
                if (BGColorString != null)
                    return (Brush)new BrushConverter().ConvertFromString(BGColorString);
                else
                    return Brushes.Green;
            } 
        }

        public Student(int indexNumber, string firstName, string lastName, DateOnly dOB, string telephone, string address, double gPA, string bGColorString)
        {
            IndexNumber = indexNumber;
            FirstName = firstName;
            LastName = lastName;
            DOB = dOB;
            Telephone = telephone;
            Address = address;
            GPA = gPA;
            BGColorString = bGColorString;
        }
    }
}
