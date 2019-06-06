using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEventsExcep
{

    //step 1 : create a delegate class having the same signature as the event handler
    public delegate void InvalidP1EventHandler();
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1,e2;
            try
            {
                //e2 = new Employee();
                e2 = new Employee(-101, "kumbhar", 10000, 10);
                InvalidP1EventHandler objDel = new InvalidP1EventHandler(obj_InvalidP1);
                e2.InvalidP1 += objDel;
                e2.EmpNo =  - 100;
                Console.ReadLine();



             //   e1 = new Employee(101,"kumbhar",10000,10);
            }
            catch (InvalidP1Exception ex)
            {
                //this is for name userdefind exception
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //this is for basic 
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadLine();

        }

        private static void obj_InvalidP1()
        {
            Console.WriteLine("event handled here");
        }
    }

    public class InvalidP1Exception : Exception
    {
        public InvalidP1Exception(string message) : base(message)
        {

        }

    }

    class Employee
    {
        //step 2 : create the event of the delegate type
        public event InvalidP1EventHandler InvalidP1;


        public Employee(int empno,String name, decimal basic = 10000, short deptNo = 10)
        {
            //sempNo = ++sempNo;
            this.EmpNo = empno; //auto assign
            this.DeptNo = deptNo;
            this.Basic = basic;
            this.Name = name;
        }

        public Employee()
        {

        }
        #region Properties
        public static int sempNo = 0;
        private int empno;
        private string name;
        private decimal basic;
        private short deptno;

        public int EmpNo
        {
          
            set
            {
                if (value > 0)
                {
                    empno = value;
                }
                else
                {
                    if (InvalidP1 != null)
                        InvalidP1();
                    //Console.WriteLine("call event");
                }
            }

            get
            {
                return empno;
            }
        }
        public string Name
        {
            set
            { if (value != "") { name = value; }
              else {
                    throw new InvalidP1Exception("Enter valid name ");
                    }
            }

            get { return name; }

        }
        public decimal Basic
        {
            set
            {
                if (value < 8000 || value > 20000)
                    throw new Exception("Enter some valid basic amount between 8K-20K");
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
