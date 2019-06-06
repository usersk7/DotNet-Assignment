using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    class Program
    {
        static void Main1(string[] args)
        {
            Student[] studentlist = new Student[2];

            for (int i = 0; i < studentlist.Length; i++)
            {
                studentlist[i] = new Student();
                Console.Write("             Enter  Student NO {0}  :", i);
                Console.WriteLine();
                Console.Write("Enter Rollno   :");
                studentlist[i].Rollno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name  : ");
                studentlist[i].Name = Console.ReadLine();
                Console.Write("Enter Subject1   :");
                studentlist[i].Subject1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Subject2  : ");
                studentlist[i].Subject2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (Student o in studentlist)
            {
                o.display();
            }
             Console.ReadLine();
        }

        static void Main()
        {
            List<Student> objstud = new List<Student>();
            objstud.Add(new Student { Rollno = 101, Name = "shubham", Subject1 = 60, Subject2 = 65 });
            objstud.Add(new Student { Rollno = 102, Name = "kunal", Subject1 = 60, Subject2 = 65 });
            objstud.Add(new Student { Rollno = 103, Name = "Pratiksha", Subject1 = 60, Subject2 = 65 });
            objstud.Add(new Student { Rollno = 104, Name = "Shikha", Subject1 = 60, Subject2 = 65 });

            foreach (Student e in objstud)
            {
                e.display();
            }

            Console.WriteLine();
            Console.WriteLine("Enter Roll no to get details");
            int rn = Convert.ToInt32(Console.ReadLine());

            foreach (Student e in objstud)
            {
                if (e.Rollno == rn)
                {
                    e.display();

                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter Roll no to delete details");
             int trn = Convert.ToInt32(Console.ReadLine());
            Student s=null;
            foreach (Student e in objstud)
            {
                if (e.Rollno == trn)
                {
                    s = e;
                }
            }

            objstud.Remove(s);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("after deleting {0}",trn);
            foreach (Student e in objstud)
            {
                e.display();
            }

            Console.WriteLine();
            Console.WriteLine();
            //=================================================

            SortedList<int, Student> objSortedList = new SortedList<int, Student>();
            objSortedList.Add(1, new Student { Rollno = 101, Name = "shubham", Subject1 = 60, Subject2 = 65 });
            objSortedList.Add(2, new Student { Rollno = 102, Name = "rohan", Subject1 = 80, Subject2 = 65 });
            objSortedList.Add(3, new Student { Rollno = 103, Name = "Pratiksha", Subject1 = 90, Subject2 = 65 });
            objSortedList.Add(4, new Student { Rollno = 104, Name = "shikha", Subject1 = 40, Subject2 = 65 });

            foreach (KeyValuePair<int, Student> objKvp in objSortedList)
            {
                Console.Write(objKvp.Key+"  "+ objKvp.Value.Rollno+"  "
                    + objKvp.Value.Name+" "+ objKvp.Value.Subject1+"  "+ objKvp.Value.Subject2);
                Console.WriteLine();
                
            }





            Console.ReadLine();
        }

       
    }
    class Student
    {
        private int rollno;// RollNo
        private string name; //Name - no blank strings
        private decimal subject1;  //Subject1 - 0 to 100
        private decimal subject2; //Subject2 - 0 to 100
        #region Propertes
        public int Rollno
        {
            get => rollno;
            set
            {
                if (value > 0)
                    rollno = value;
                else
                    Console.WriteLine("enterr valid roll number");
            }
        }
        public string Name
        { get => name;
          set
            {
                if (value !="")
                    name = value;
                else
                    Console.WriteLine("Enter Name "); }
        }
        public decimal Subject1
        { get => subject1;
          set
            { if (value > 0 && value<100)
                    subject1 = value;
                else
                    Console.WriteLine("Enter valid Marks 0-100");
            }
        }
        public decimal Subject2
        { get => subject2;
          set
            { if (value > 0 && value < 100)
                    subject2 = value;
              else
                    Console.WriteLine("Enter valid Marks 0-100");
            }
        }
        #endregion

        public decimal GetPercentage(Student obj)
        {
            decimal percentage = (obj.Subject1 + obj.Subject2) / 2;
            return percentage;
        }

        public void  display()
        {
            Console.WriteLine( Rollno + " " + Name + " " + Subject1 + " " + Subject2 +"  "+ GetPercentage(this));
        }

             

    }

    class Students : List<Student>
    {
        
    }

}
