using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Individual_Project_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else if(this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)((Button)sender).CommandParameter;
            var editWindow = new EditStudentWindow(selectedStudent);
            editWindow.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)((Button)sender).CommandParameter;

            // Create a new EditStudentWindow and pass the selected student as a constructor argument
            var deleteWindow = new DeleteWindow(selectedStudent);
            deleteWindow.ShowDialog();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void regNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            studentDataGrid.ItemsSource = MainWindowVM.Students.Where(s => s.FullName.ToUpper().Contains(indexNo.Text.ToUpper()));
        }
    }
}
