using System;
using System.Text;

namespace lab02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Vui lòng nhập vào mã SIN bạn muốn kiểm tra");
                int SIN;
                while (true)
                {
                    SIN = int.Parse(Console.ReadLine());
                    if (SIN.ToString().Length == 9 && SIN != 0)
                    {
                        break;
                    }
                    else
                    {
                        if (SIN == 0)
                        {
                            break;
                        }

                        Console.WriteLine("Mã SIN là mã bao gồm 9 chữ số vui lòng nhập đúng 9 chữ số");
                    }
                }
                var checkValid = CheckResult(SIN);
                if (checkValid)
                {
                    Console.WriteLine("Đây là một số SIN hợp lệ");
                }
                else if (!checkValid && SIN != 0)
                {
                    Console.WriteLine("Đây không phải là SIN hợp lệ.");
                }
                if (SIN == 0)
                {
                    Console.WriteLine("Chúc một ngày tốt lành!");
                    break;
                }

                Console.WriteLine("Bạn có muốn kiểm tra tiếp không (1.Tiếp tục/2.Thoát) ?");
                var luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        private static bool CheckResult(int sin)
        {
            var listNumber = new int[9];
            for (int i = 0; i < sin.ToString().Length; i++)
            {
                var number = int.Parse(sin.ToString()[i].ToString());
                listNumber[i] = number;
            }
            // tạo ra chuỗi số từ x2 các số ỏ vị trí 2 , 4 , 6 , 8
            var stringNumber1 = "";
            for (int i = 1; i < listNumber.Length; i += 2)
            {
                stringNumber1 += listNumber[i] * 2;
            }
            //tính tổng các số đơn lẻ từ chuỗi trên
            var number1 = 0;
            for (int i = 0; i < stringNumber1.Length; i++)
            {
                number1 += int.Parse(stringNumber1[i].ToString());
            }
            // tạo ra chuỗi số từ các số ỏ vị trí 1 , 3 , 5 , 7
            var stringNumber2 = "";
            for (int i = 0; i < listNumber.Length - 1; i += 2)
            {
                stringNumber2 += listNumber[i];
            }
            //tính tổng các số đơn lẻ từ chuỗi trên
            var number2 = 0;
            for (int i = 0; i < stringNumber2.Length; i++)
            {
                number2 += int.Parse(stringNumber2[i].ToString());
            }
            var total = number1 + number2;
            var count = total;
            while (true)
            {
                count++;
                if (count % 10 == 0)
                {
                    break;
                }
            }
            if (count - total == listNumber[listNumber.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}