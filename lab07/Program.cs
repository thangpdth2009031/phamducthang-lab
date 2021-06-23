using System;
using System.Globalization;

namespace lab07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employeeManager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("1.Add new staff");
                Console.WriteLine("2.Show List");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Exit the program");
                Console.WriteLine("Please enter your choice: ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeManager.Create();
                        break;
                    case 2:
                        employeeManager.Display();
                        break;
                    case 3:
                        employeeManager.Update();
                        break;
                    case 4:
                        employeeManager.Delete();
                        break;
                    case 5:
                        break;
                }

                if (choice == 5)
                {
                    break;    
                }
            }
        }
    }
}