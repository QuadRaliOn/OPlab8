using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OPlab8
{
    public class Unit : IEmployeeble
    {
        public string Name { get; set; }

        public List<Employee> employees = new List<Employee>();
        public List<Project> projects = new List<Project>();

        public void SortEmployees()
        {
            employees.Sort();
        }

        public void SortProjects()
        {
            projects.Sort((a,b) => a.GetPrice().CompareTo(b.GetPrice()));
        }

        public int GetProjectsPrice()
        {
            int sum = 0;
            foreach (var item in projects)
            {
                sum += item.GetPrice();
            }
            return sum;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}
