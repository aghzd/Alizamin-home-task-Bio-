namespace HR__Management_App_Mini_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Asif","AsifHoldings");
            employee.Salary = 5000;
            employee.Position = "Mudir";
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.Position);
            Console.WriteLine(employee.No(12));



            Department department = new Department();
            department.WorkerLimit = 10;
            department.SalaryLimit = 300;
            department.Name = "ElsenLogistic";
            Console.WriteLine(department.WorkerLimit);
            Console.WriteLine(department.Name);
            department.CalcSalaryAverage();
        }
    }
}
