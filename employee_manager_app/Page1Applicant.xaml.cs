using employee_manager_app.Models;
using employee_manager_app.Services;
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
    /// Логика взаимодействия для Page1Applicant.xaml
    /// </summary>
    public partial class Page1Applicant : Page
    {
        public Page1Applicant()
        {
            InitializeComponent();
        }

        private readonly string PATH = $"{Environment.CurrentDirectory}\\applicantDataList.json";
        private BindingList<applicant> _applicantDataList;
        private DataInputOutputService _dataInputOutputService;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _dataInputOutputService = new DataInputOutputService(PATH);

            try
            {
                _applicantDataList = _dataInputOutputService.LoadData();
            }
            catch (Exception ex)
            {
                       MessageBox.Show(ex.Message);

            }
            applicantList.ItemsSource = _applicantDataList;
            _applicantDataList.ListChanged += _applicantDataList_ListChanged;

        }

        private void _applicantDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _dataInputOutputService.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
