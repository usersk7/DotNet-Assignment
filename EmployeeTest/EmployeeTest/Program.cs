using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class EmployeeMain
    {
        static void Main(string[] args)
        {

            Console.WriteLine("EmpNo " + "Name " + " Basic" + " DeptNo");
            Console.WriteLine();


            Employee e = new Employee("shubham",10000,10);
            Console.WriteLine(" " + e.EmpNo + " " + e.Name+ " " + e.Basic+" " +e.DeptNo);
            Console.WriteLine();

            Employee e1 = new Employee("Pratiksha", 20000, 10);
            Console.WriteLine(" " + e1.EmpNo + " " + e1.Name + " " + e1.Basic + " " + e1.DeptNo);
            Console.WriteLine();

            Employee e2 = new Employee("Kumbhar", 10000, 10);
            Console.WriteLine(" " + e2.EmpNo + " " + e2.Name + " " + e2.Basic + " " + e2.DeptNo);
            //Console.WriteLine(e2);
            Console.WriteLine();

            Console.ReadLine();
            
        }
    }
        class Employee
        {

        public Employee(String name, decimal basic = 10000, short deptNo = 10)
        {
            sempNo = ++sempNo;

            this.empno = sempNo; //auto assign
            this.DeptNo = deptNo;
            this.Basic = basic;
            this.Name = name;

        }

        #region Properties
        public static int sempNo = 0;
            private int empno;
            private string name;
            private decimal basic;
            private short deptno;


           


            public int EmpNo
            {
             
                get
                {
                    return empno;
                }
            }

            
            public string Name
            {
                set{ if (value != "") { name = value; }      else { Console.WriteLine("Enter valid "); }}

                get{return name;}

            }

            public decimal Basic
              {
                set
                {
                    if (value < 8000 || value > 20000)
                        Console.WriteLine("Enter some valid basic amount between 8K-20K");
                    else
                        basic = value;
                }
                get
                {
                    return basic;
                }

            }

            public short DeptNo
            {
                set { if (value > 0) deptno = value; else Console.WriteLine("Enter valid Department Number"); }
                get { return deptno; }
            }

            #endregion

        }

}

