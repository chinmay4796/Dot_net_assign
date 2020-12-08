using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssign
{
    class Program
    {
        static void Main()
        {
            // 1. simple Interest
            Func<decimal, decimal, decimal, decimal> SimpleInterest = (p, n, r) => n * p * r;
            Console.WriteLine("Simple Interest : "+ SimpleInterest(20000,4,5));

            // 2. greater
            Func<int, int, bool> isGreater = (a, b) => a > b;
            Console.WriteLine("a > b =>"+ isGreater(6,4));

            //3
            Func<int, bool> Even = (a) => a % 2 == 0;
            Console.WriteLine("No. is Even =>"+ Even(4));

            // 4.isGreaterThan10000
            Employee e = new Employee();
            //Func<Employee, bool> o = (a) => e.basicSalary > 10000;

            //Employee e = new Employee() { basicSalary = 12000 };

            Predicate<Employee> o = (emp) => e.basicSalary > 10000;
            Console.WriteLine("isGreater than 10000"+o(e));
            Console.ReadLine();


        }
    }

    public class Employee
    {
        public int basicSalary = 40000;

        public Employee()
        {

        }


    }
}
