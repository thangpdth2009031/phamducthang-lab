using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public class EmployeeManager
    {
        private Dictionary<string, Employee> _employees = new Dictionary<string, Employee>();  
        public void Create()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tuổi: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập lương: ");
            var salary = double.Parse(Console.ReadLine());
            _employees.Add(id, new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
        }

        public void Update()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Vui lòng nhập id nhân viên muốn sửa: ");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                Console.WriteLine("Vui lòng nhập tên mới: ");
                var name = Console.ReadLine();
                Console.WriteLine("Vui lòng nhập tuổi mới: ");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("Vui lòng nhập lương mới: ");
                var salary = double.Parse(Console.ReadLine());
                _employees[id].Age = age;
                _employees[id].Name = name;
                _employees[id].Salary = salary;
                Console.WriteLine("Sửa thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên.");
            }
        }

        public void Delete()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Vui lòng nhập id nhân viên muốn xoá: ");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                _employees.Remove(id);
                Console.WriteLine("Xoá thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên.");
            }
        }

        public void Display()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            if (_employees.Count == 0)
            {
                Console.WriteLine("Danh sách trống vui lòng thêm mới.");
            }
            foreach (var list in _employees)
            {
                Console.WriteLine($"Id: {list.Key}, {list.Value}");
            }
        }
    }
}