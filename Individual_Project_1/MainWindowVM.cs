using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Individual_Project_1
{
    public partial class MainWindowVM:ObservableObject
    {
        
        public static ObservableCollection<Student> Students { get; set; }
        public static int index = 1000;
        public MainWindowVM()
        {
            Students = new ObservableCollection<Student>();
            Students.Add(new Student(++index, "Tom", "Brown", new DateOnly(2000, 1, 1), "(123) 456-7890", "123 Main St, Anytown USA", 3.9, "#FF008000"));
            Students.Add(new Student(++index, "Jessica", "Lee", new DateOnly(2001, 2, 14), "(234) 567-8901", "456 Oak St, Anytown USA", 3.8, "#FFFF0000"));
            Students.Add(new Student(++index, "William", "Garcia", new DateOnly(2002, 3, 27), "(345) 678-9012", "789 Maple St, Anytown USA", 3.7, "#FF8B008B"));
            Students.Add(new Student(++index, "Emily", "Kim", new DateOnly(2003, 4, 30), "(456) 789-0123", "123 Cherry Ave, Anytown USA", 3.6, "#FF0000FF"));
            Students.Add(new Student(++index, "Jacob", "Wang", new DateOnly(2004, 5, 13), "(567) 890-1234", "456 Pine St, Anytown USA", 3.5, "#FF008000"));
            Students.Add(new Student(++index, "Mia", "Nguyen", new DateOnly(2005, 6, 26), "(678) 901-2345", "789 Cedar St, Anytown USA", 3.4, "#FF0000FF"));
            Students.Add(new Student(++index, "Ethan", "Singh", new DateOnly(2006, 7, 9), "(789) 012-3456", "123 Oak St, Anytown USA", 3.3, "#FF8B008B"));
            Students.Add(new Student(++index, "Olivia", "Gupta", new DateOnly(2007, 8, 22), "(890) 123-4567", "456 Maple St, Anytown USA", 3.2, "#FF0000FF"));
            Students.Add(new Student(++index, "Michael", "Patel", new DateOnly(2008, 9, 4), "(901) 234-5678", "789 Cherry Ave, Anytown USA", 3.1, "#FF008000"));
            Students.Add(new Student(++index, "Sophia", "Lee", new DateOnly(2009, 10, 17), "(012) 345-6789", "123 Pine St, Anytown USA", 3.0, "#FFFF0000"));

        }

        [RelayCommand]
        public void AddStudent()
        {
            var window = new AddStudentWindow();
            window.ShowDialog();
        }
    }
}
