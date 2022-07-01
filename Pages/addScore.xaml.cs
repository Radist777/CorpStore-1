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
    /// Логика взаимодействия для addScore.xaml
    /// </summary>
    public partial class addScore : Window
    {
        public int _id;
        public static employeesEntities entities { get; set; }
        public addScore(int id)
        {
            _id = id;
            entities = new employeesEntities();
            InitializeComponent();
        }

        private void OkCLick(object sender, RoutedEventArgs e)
        {
            var result = entities.Employee.SingleOrDefault(b => b.Id == _id);
            if (result != null)
            {
                if ((bool)cb1.IsChecked)
                {
                    result.Score += 10;
                    result.History.Item += "Получено 10 баллов за без опозданий\n";
                    entities.SaveChanges();
                }
                if ((bool)cb2.IsChecked)
                {
                    result.Score += 20;
                    result.History.Item += "Получено 20 баллов за переработку\n";
                    entities.SaveChanges();
                }
                if ((bool)cb3.IsChecked)
                {
                    result.Score += 100;
                    result.History.Item += "Получено 100 баллов за красивые глаза\n";
                    entities.SaveChanges();
                }
                if ((bool)cb4.IsChecked)
                {
                    result.Score += 5;
                    result.History.Item += "Получено 5 баллов за то что есть пару лишних\n";
                    entities.SaveChanges();
                }
                if ((bool)cb5.IsChecked)
                {
                    result.Score += 1;
                    result.History.Item += "Получено 1 баллов за 1Ц кэшбэк\n";
                    entities.SaveChanges();
                }
            }
            DialogResult = true;
        }

        private void CloseClock(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
