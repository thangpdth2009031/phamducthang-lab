using System;
using System.Collections;
using System.Text;
namespace lab08.lab08Ex2
{
    public class Lab08Ex2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var random = new Random();
            var temperature = new double[300];
            for (var i = 0; i < 300; i++)
            {
                temperature[i] = random.Next(0, 1000);
            }

            while (true)
            {
                Console.Write("Vui lòng nhập vào số min : ");
                var min = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    $"GreaterCount trả về : {GreaterCount(temperature, min)} lần temperature lớn hơn số min đã nhập.\n\n");
            }
        }

        public static int GreaterCount(IEnumerable enumerable, double min)
        {
            var count = 0;
            foreach (var item in enumerable)
            {
                if (double.Parse(item.ToString()) >= min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}