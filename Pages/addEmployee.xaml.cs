using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для addEmployee.xaml
    /// </summary>
    public partial class addEmployee : Window
    {
        public static employeesEntities entities { get; set; }
        
        public addEmployee()
        {
            entities = new employeesEntities();
            InitializeComponent();
        }



        private void OkBtnCl(object sender, RoutedEventArgs e)
        {
            var emp = Employee.CreateEmployee(fName.Text, lName.Text, GetHistoryId());
            entities.Employee.Add(emp);
            entities.SaveChanges();
            DialogResult = true;
        }

        private int GetHistoryId()
        {
            int id;
            var history = History.CreateHistory();
            entities.History.Add(history);
            entities.SaveChanges();
            id = history.Id;
            return id;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
