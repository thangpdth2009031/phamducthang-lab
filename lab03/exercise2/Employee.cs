using System;
using System.Text;

namespace lab02
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }
        
        public void ToString()
        {
            Console.WriteLine($"Full Name: {FirstName}  {LastName}, Address: {Address}, Sin: {Sin}, Salary: {Salary}");
        }
        public void TienLuong(double percentage)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Tiền lương: {this.Salary * percentage / 100}");
            
        }
    }
}