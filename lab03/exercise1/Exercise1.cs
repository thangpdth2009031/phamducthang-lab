using System;
using System.Text;

namespace lab03.exercise1
{
    public class Exercise1
    {
        public static void Main(string[] args)
        {
            Atom atom = new Atom();
            while (true)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Chọn 1 để thêm mới");
                Console.WriteLine("Chọn 2 để hiển thị");
                Console.WriteLine("Chọn 3 để thoát");
                Console.WriteLine("Vui lòng nhập lựa chọn của bạn(1-3):");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        atom.Accept();
                        break;
                    case 2:
                        atom.Display();
                        break;
                    case 3:
                        break;
                }
        
                if (choice == 3)
                {
                    Console.WriteLine("Thoát chương trình.");
                    break;
                }
            }
        }
    }
}