using System;
using System.Text;

namespace lab04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var student = new Student()
            {
                Name = "Phạm Đức Thắng",
                Phone = "09090909",
                Email = "thangpd@gmail.com",
                Program = "ISA"
            };

            var staff = new Staff
            {
                Name = "Phạm Đức Thắng",
                Phone = "09090909",
                Email = "thangpd@gmail.com",
                Title = "Nhân viên thu ngân",
                Salazy = 550,
                Department = "Kế toán",
                DateHired = 5
            };
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"Thưởng của {staff.Name} là : {staff.CalculateBonus()}");
            Console.WriteLine($"Tuần nghỉ của {staff.Name} là : {staff.CalculateVacation()}");


            var faculty = new Faculty()
            {
                Name = "Hà Duy Nhật",
                Phone = "0987987789",
                Email = "nhat@gmail.com",
                OfficeHour = "8h - 17h00",
                Salazy = 400,
                DateHired = 5,
                Rank = 1,
                Department = "2009m1"
            };
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"Thưởng của {faculty.Name} là : {faculty.CalculateBonus()}");
            Console.WriteLine($"Tuần nghỉ của {faculty.Name} là : {faculty.CalculateVacation()}");
        }
    }
}