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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public static employeesEntities entities { get; set; }
        public Home()
        {
            entities = new employeesEntities();
            InitializeComponent();
        }

        private void addEmp(object sender, RoutedEventArgs e)
        {
            var addEmp = new addEmployee();
            var result = addEmp.ShowDialog();
            addList();
            if (result != true) return;
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            addList();
        }
        private void addList()
        {
            var listEmp = entities.Employee.ToList();
            listV.ItemsSource = listEmp;
            listV.Items.Refresh();
        }

        private void selectionIn(object sender, SelectionChangedEventArgs e)
        {
            addScore.IsEnabled = listV.SelectedItem != null;
            info.IsEnabled = listV.SelectedItem != null;
        }

        private void addScore_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = (Employee)listV.SelectedItem;
            var addScore = new addScore(emp.Id);
            var result = addScore.ShowDialog();
            addList();
            if (result != true)
            {
                return;
            }
        }

        private void refClicl(object sender, RoutedEventArgs e)
        {
            addList();
        }

        private void infoClick(object sender, RoutedEventArgs e)
        {
            Employee emp = (Employee)listV.SelectedItem;
            var addScore = new Info(emp.Id);
            var result = addScore.ShowDialog();
            if (result != true)
            {
                return;
            }
        }
    }
}
