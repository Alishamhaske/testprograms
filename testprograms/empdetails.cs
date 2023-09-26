using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace testprograms
{
    public class empdetails
    {
        static void Main(string[] args)
        {
            employee e1 = new employee("Alisha", 40000);
            employee e2 = new employee("tanu", 40000);
          
            e1.calsalary();
            Console.WriteLine(e1.displaydata());

           // e2.print();
            e2.calsalary();
            Console.WriteLine(e2.displaydata());

            Console.ReadLine();
        }
    }
    //
    public class employee
    {
       
        public  int emp_id;
        public static int count;
        string emp_name;

     
        private double emp_salary, hra, da, ta, pf, gross;
        public employee(string name,double emp_salary)
        {
            count++;
            this.emp_id = count;
            this.emp_name = name;
            this.emp_salary = emp_salary;
        }
        public void print()
        {
            Console.WriteLine($"employee id:{emp_id}  employee name:{emp_name} employee salary: {emp_salary} ");
        }

        public void calsalary()
        {
            hra = emp_salary * 0.40;
            da = emp_salary * 0.20;
            ta = emp_salary * 0.10;
            pf = emp_salary * 0.12;
            gross = (emp_salary + hra + da + ta) - pf;
        }
        public string displaydata()
        {
            return $"employee id:{emp_id}  employee name:{emp_name} employee salary: {emp_salary} Gross salary: {gross}";
        }
          
    }
}
