using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_1
{
    public partial class AddStudentWindowVM:ObservableObject
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Addr { get; set; }
        public DateTime DatePickerDate { get; set; }
        public DateOnly Dob 
            {
            get {return DateOnly.FromDateTime(DatePickerDate); }
            }
        public string Tel { get; set; }
        public double Gpa { get; set; }

        public string Bgcode { get; set; }

        public AddStudentWindowVM()
        {
            DatePickerDate = new DateTime(2000,01,01);
        }

        [RelayCommand]
        public void addStudent()
        {
            if(FName!=null && LName!=null && Tel!=null && Addr!=null && Bgcode != null)
            {
                var student = new Student(++MainWindowVM.index, FName, LName, Dob, Tel, Addr, Gpa, Bgcode);
                MainWindowVM.Students.Add(student);
                var w = new MWindow("Student Added");
                w.ShowDialog();
            }
            else
            {
                if (FName == null)
                {
                    var w = new MWindow("Please Enter First Name");
                    w.ShowDialog();
                }
                else if(LName == null)
                {
                    var w = new MWindow("Please Enter Last Name");
                    w.ShowDialog();
                }
                else if (Addr == null)
                {
                    var w = new MWindow("Please Enter Address");
                    w.ShowDialog();
                }
                else if (Tel == null)
                {
                    var w = new MWindow("Please Enter Telephone Number");
                    w.ShowDialog();
                }
                else if (Bgcode == null)
                {
                    var w = new MWindow("Please Select a Avatar Color");
                    w.ShowDialog();
                }
            }
            
        }

        [RelayCommand]
        public void setColor(string code)
        {
            Bgcode = code;
        }
    }
}
