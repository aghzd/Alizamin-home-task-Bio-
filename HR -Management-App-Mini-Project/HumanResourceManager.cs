using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR__Management_App_Mini_Project
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> Departments { get; set; }

        public void AddDepartment(string Name, int WorkerLimit, int SalaryLimit)
        {
          Departments.Add(new Department() { Name = Name, WorkerLimit = WorkerLimit, SalaryLimit = SalaryLimit });
            
        }


        public void AddEmployee()
        {
           
            
        }

        public void EditDepartment()
        {
           
        }

        public void EditEmployee()
        {
            
        }

        public void GetDepartment()
        {
            
        }

        public void RemoveEmployee()
        {
            
        }

        public void Search()
        {
            
        }
    }
}
