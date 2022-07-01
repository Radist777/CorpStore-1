//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFModernVerticalMenu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        public int HistoryId { get; set; }
    
        public virtual History History { get; set; }
        private static Employee _emp;
        public static Employee CreateEmployee(string fName, string lName, int id)
        {
            _emp = new Employee
            {
                FirstName = fName,
                LastName = lName,
                HistoryId = id
            };
            return _emp;
        }
    }
}
