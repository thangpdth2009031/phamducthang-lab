using System;
using System.Collections.Generic;

namespace lab03.exercise1
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string FullName { get; set; }
        public float Weight { get; set; }
        
        public bool Accept()
        {
            try
            {
                Console.WriteLine("Enter atomic number: ");
                this.Number = Convert.ToInt32(Console.ReadLine());
                if (this.Number == 0)
                {
                    return false;
                }
                Console.WriteLine("Enter symbol: ");
                this.Symbol = Console.ReadLine();
                Console.WriteLine("Enter full name: ");
                this.FullName = Console.ReadLine();
                Console.WriteLine("Enter atomic weight: ");
                this.Weight = float.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{this.Number} {this.Symbol} {this.FullName} {this.Weight}");
        }
    }
}