using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR__Management_App_Mini_Project
{
    internal class Employee
    {

        
        public string FullName { get; set; }

        private string _position;
        public string Position 
        {
            get
            {
                return _position;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length <= 2)
                throw new ArgumentException("Vezife en az 2 herfden ibaret olmalidir");
                _position = value;
            }
        }
        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }

            set 
            {
                if (value > 250)
                    _salary = value;
                else
                throw new ArgumentException("Maas 250 den az ola bilmez");
                
            }
        }
        public string DepartmentName { get; set; }


        public Employee( string fullName, string departmentName)
        {
            
            FullName = fullName;
            DepartmentName = departmentName;
        }

        public string No (int workernumber)
        {
            string firstTwoLetter = DepartmentName.Substring(0,2).ToUpper();

            return "isci nomresi:" + firstTwoLetter + (workernumber + 1000).ToString();
        }

        


    }
}
