using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HR__Management_App_Mini_Project
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> Departments { get; set; }

        public void AddDepartment(string name, int workerLimit, int salaryLimit)
        {
          Departments.Add(new Department() { Name = name, WorkerLimit = workerLimit, SalaryLimit = salaryLimit });
            
        }

        public List<Department> GetDepartment()
        {
            return Departments;
        }
        public void EditDepartment(string name, string newName)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Ad daxil edilmemisdir");
            if (Departments.Any(d => d.Name == name))
            {
                var existDepartment = Departments.Find(d => d.Name == name);
                existDepartment.Name = newName;
            }
            throw new Exception($"{name} adli Departmanet tapilmadi...");
        }

        public void AddEmployee()
        {
           
            
        }

       

        public void EditEmployee()
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
