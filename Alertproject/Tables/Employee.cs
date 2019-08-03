using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alertproject.Tables
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public DateTime StartDate { get; set; }
        public string JobTitle { get; set; }
        public string Email{ get; set; }
        public string Status { get; set; }
    }
}
