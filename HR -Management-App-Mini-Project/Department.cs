using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR__Management_App_Mini_Project
{
    internal class Department
    {
        private string _name;
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 2 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ad duzgun daxil edilmemisdir");
                _name = value;
            }
        }
        private int _workerLimit;
        public int WorkerLimit 
        {
            get
            {
                return _workerLimit;
            }

            set
            {
                if (value >= 1)
                    _workerLimit = value;
                else
                    throw new ArgumentException("Isci sayi duzgun deyil");
            }
        }

        private int _salaryLimit;
        public int SalaryLimit 
        {
            get
            {
                return _salaryLimit;
            }

            set
            {
                if (value > 250)
                    _salaryLimit = value;
                else
                    throw new ArgumentException("Daxil edilen maas teyin edilen araliqda deyil");
            }
        }

        //employees listi elave ele videoya bax 
        //list qalib 

        
        public void CalcSalaryAverage()
        {
            int result = 0;
            for (int i = 0; i <= _workerLimit; i++)
            {
                result += _salaryLimit;
            }
            result = result / _workerLimit;
            Console.WriteLine("Iscilerin aligi orta maas "+ result + " a beraberdir" );
        }





    }
}
