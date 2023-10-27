using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeahvioralDesignDemo_Iterator
{
    public class Employee
    {
        
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }

        public Employee(int id,string name,int sal)
        {
            Empid = id;
            EmpName = name;
            Salary = sal;
        }
    }


    interface Iterator
    {
         Employee GetFirst();


         Employee GetLast();
        bool Iscompleted { get; }

    }

    class ImplementIterator : Iterator
    {
        private ConcreteCollection emplist;
        public bool Iscompleted => throw new NotImplementedException();
        private int current = 0;
        public Employee GetFirst()
        {
            //throw new NotImplementedException();
            current = 0;
            return emplist.GetEmployee(current);
        }

        public Employee GetLast()
        {
            //throw new NotImplementedException();
            current=emplist.Count;
            return emplist.GetEmployee(current);    

        }
    }

    class ConcreteCollection
    { 
    private List<Employee> employees = new List<Employee>();

        public int Count { get { return employees.Count; }  }

        public void AddEmployee(Employee emp)
        { 
        employees.Add(emp);
        }


        public Employee GetEmployee(int index) { 
        return employees[index];    
        }

    }




}
