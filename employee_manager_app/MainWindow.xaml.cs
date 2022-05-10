using System;
using System.Collections.Generic;
using System.ComponentModel;
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



namespace employee_manager_app
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void applicantButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page1Applicant();
        }

        private void employeeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page2Employee();
        }

        private void positionButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page3Position();
        }

        private void structuralDivisionButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page4StructuralDivision();
        }


    }
}
