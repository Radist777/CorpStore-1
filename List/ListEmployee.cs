using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.List
{
    class ListEmployee : ObservableCollection<Employee>
    {
        public static employeesEntities employees { get; set; }

        public ListEmployee()
        {
            employees = new employeesEntities();
            DbSet<Employee> emp = employees.Employee;
            foreach (Employee pub in emp)
            {
                Add(pub);
            }
        }
    }
}
