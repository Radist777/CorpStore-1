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
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public int _id;
        public static employeesEntities entities { get; set; }
        public Info(int id)
        {
            _id = id;
            entities = new employeesEntities();
            InitializeComponent();
        }

        private void closeCl(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void wLoaded(object sender, RoutedEventArgs e)
        {
            var result = entities.Employee.SingleOrDefault(b => b.Id == _id);
            score.Content += result.Score.ToString();
            name.Content += result.FirstName;
            lname.Content += result.LastName;
            historyBlock.Text += result.History.Item;
        }
    }
}
