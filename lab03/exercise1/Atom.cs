using System;
using System.Collections.Generic;

namespace lab03.exercise1
{
    public class Atom
    {
        public int number { get; set; }
        public string symbol { get; set; }
        public string fullName { get; set; }
        public double weight { get; set; }

        public List<Atom> _ListAtom = new List<Atom>();

        public bool Accept()
        {
            Atom atom = new Atom();
            Console.WriteLine("Enter atomic number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            atom.number = number;
            Console.WriteLine("Enter symbol : ");
            var symbol = Console.ReadLine();
            atom.symbol = symbol;
            Console.WriteLine("Enter full name : ");
            var fullName = Console.ReadLine();
            atom.fullName = fullName;
            Console.WriteLine("Enter atomic weight : ");
            var weight = double.Parse(Console.ReadLine());
            atom.weight = weight;
            _ListAtom.Add(atom);
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < _ListAtom.Count; i++)
            {
                Atom atom = _ListAtom[i];
                if (_ListAtom.Count > 10)
                {
                    Console.WriteLine("Chỉ nhận tối đa mười phần tử: ");
                }
                else
                {
                    Console.WriteLine(
                        $"Number: {atom.number}, Symbol: {atom.symbol}, Full Name: {atom.fullName}, Weight: {atom.weight}");
                }
            }
        }
    }
}