using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyFirstEmpPage.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public int EmpID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public byte Age
        {
            get
            {
                return (byte)((DateTime.Now - DOB).TotalDays / 365);
            }
        }
        public string PrintGender
        {
            get
            {
               return Gender == 'M' ? "Male" : "Female";
            }
        }
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime DOB { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DOJ { get; set; }
        [DisplayFormat(DataFormatString = "{0}")]
        public decimal Salary { get; set; }
        public Department department { get; set; }
    }
}