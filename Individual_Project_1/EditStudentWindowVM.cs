using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_1
{
    public partial class EditStudentWindowVM:ObservableObject
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Addr { get; set; }
        public DateTime DatePickerDate { get; set; }
        public DateOnly Dob
        {
            get { return DateOnly.FromDateTime(DatePickerDate); }
        }
        public string Tel { get; set; }
        public double Gpa { get; set; }
        public string Bgcode { get; set; }
        public int Indx { get; set; }
        public bool IsGreen { get; set; }
        public bool IsRed { get; set; }
        public bool IsBlue { get; set; }
        public bool IsPurple { get; set; }


        public EditStudentWindowVM(Student std)
        {
            FName = std.FirstName;
            LName = std.LastName;
            Addr = std.Address;
            DatePickerDate = new DateTime(std.DOB.Year, std.DOB.Month, std.DOB.Day);
            Tel = std.Telephone;
            Gpa = std.GPA;
            Bgcode = std.BGColorString;
            Indx = std.IndexNumber;
            if(std.BGColorString== "#FF008000")
                IsGreen = true;
            if( std.BGColorString== "#FFFF0000")
                IsRed = true;
            if(std.BGColorString== "#FF0000FF")
                IsBlue = true;
            if (std.BGColorString == "#FF8B008B")
                IsPurple = true;
        }

        public EditStudentWindowVM()
        {
            
        }

        [RelayCommand]
        public void setColor(string code)
        {
            Bgcode = code;
        }

        [RelayCommand]
        public void setChanges(string s)
        {
            if (FName != "" && LName != "" && Tel != "" && Addr != "" && Bgcode != "")
            {
                var student = new Student(Indx, FName, LName, Dob, Tel, Addr, Gpa, Bgcode);
                int index = MainWindowVM.Students.IndexOf(MainWindowVM.Students.FirstOrDefault(s => s.IndexNumber == Indx));
                MainWindowVM.Students[index] = student;
                var w = new MWindow("Student Updated");
                w.ShowDialog();
            }
            else
            {
                if (FName == "")
                {
                    var w = new MWindow("Please Enter First Name");
                    w.ShowDialog();
                }
                else if (LName == "")
                {
                    var w = new MWindow("Please Enter Last Name");
                    w.ShowDialog();
                }
                else if (Tel == "")
                {
                    var w = new MWindow("Please Enter Telephone Number");
                    w.ShowDialog();
                }
                else if (Addr == "")
                {
                    var w = new MWindow("Please Enter Address");
                    w.ShowDialog();
                }
                else if (Bgcode == "")
                {
                    var w = new MWindow("Please Select a Avatar Color");
                    w.ShowDialog();
                }
            }
            
        }
    }
}
