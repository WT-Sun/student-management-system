using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using Question_4;

namespace Data
{
    class EF
    {
        private static EmpDeptEntities db = new EmpDeptEntities();

        private static ObservableCollection<Departments> ODDepartments = null;
        private static bool initDepartments = false;

        private static ObservableCollection<Employees> ODEmployees = null;
        private static bool initEmployees = false;

        internal static ObservableCollection<Question_4.Departments> GetDepartments()
        {
            if (!initDepartments)
            {
                db.Departments.Load();
                ODDepartments = db.Departments.Local;
                initDepartments = true;
            }
            return ODDepartments;
        }
        internal static ObservableCollection<Employees> GetEmployees()
        {
            if (!initEmployees)
            {
                db.Employees.Load();
                ODEmployees = db.Employees.Local;
                initEmployees = true;
            }
            return ODEmployees;
        }
        internal static int SaveChanges()
        {
            try
            {
                db.SaveChanges();
                return 0;
            }
            catch (Exception)
            {

                Reload();
                return -1;
            }
        }
        internal static void Reload()
        {
            db = new EmpDeptEntities();
            initDepartments = false;
            initEmployees = false;
        }
    }
}
