using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Individual_Project_1
{
    public partial class DeleteWindowVM:ObservableObject  
    {
        public int Indx { get; set; }
        public DeleteWindowVM()
        {
            
        }

        public DeleteWindowVM(Student std)
        {
            Indx = std.IndexNumber;
        }

        [RelayCommand]
        public void deleteStudent()
        {
            MainWindowVM.Students.Remove(MainWindowVM.Students.FirstOrDefault(s => s.IndexNumber == Indx));
            var w = new MWindow("Student Deleted !!!");
            w.ShowDialog();
        }
    }
}
