using System;
using System.Collections.Generic;

#nullable disable

namespace AzureDBDemo.OrgModel
{
    public partial class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public double? Salary { get; set; }
    }
}
