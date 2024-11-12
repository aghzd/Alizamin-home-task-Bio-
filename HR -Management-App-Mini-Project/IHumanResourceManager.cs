using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR__Management_App_Mini_Project
{
    internal interface IHumanResourceManager
    {
        List <Department> Departments { get; set; }
        void AddDepartment(string Name, int WorkerLimit, int SalaryLimit);
        void GetDepartment();
        void EditDepartment();
        void AddEmployee();
        void RemoveEmployee();
        void EditEmployee();
        void Search();


    }
}
