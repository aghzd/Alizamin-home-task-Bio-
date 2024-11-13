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
        void AddDepartment(string name, int workerLimit, int salaryLimit);
        List<Department> GetDepartment();
        void EditDepartment(string name, string newName);
        void AddEmployee();
        void RemoveEmployee();
        void EditEmployee();
        void Search();


    }
}
