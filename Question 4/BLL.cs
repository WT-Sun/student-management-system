using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Departments
    {
        static internal int UpdateDepartments()
        {
            return Data.EF.SaveChanges();
        }

        static internal int DeleteDepartments(int deptId)
        {
            try
            {
                return Data.EF.SaveChanges();
            }
            catch (Exception ex)
            {
                Question_4.Form1.BLLMessage("Fail to delete " + ex.Message);
                return -1;
            }
        }
    }
    class Employees
    {
        static internal int UpdateEmployees()
        {
            return Data.EF.SaveChanges();
        }

        static internal int DeleteEmployee(int empId)
        {
            try
            {
                return Data.EF.SaveChanges();
            }
            catch (Exception ex)
            {
                Question_4.Form1.BLLMessage("Fail to delete " + ex.Message);
                return -1;
            }
        }
    }
}
