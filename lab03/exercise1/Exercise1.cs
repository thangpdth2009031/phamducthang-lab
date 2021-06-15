using System;
using System.Text;

namespace lab03.exercise1
{
    public class Exercise1
    {
        public static void Main(string[] args)
        {
            var atoms = new Atom[10];
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            var count = 0;
            for (int i = 0; i < 10; i++)
            {
                var atom = new Atom();
                var result = atom.Accept();
                if (!result || atom.Number == 0)
                {
                    break;
                }
                atoms[i] = atom;
                count++;
            }

            Console.WriteLine("No Sym Name Weight");
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < count; i++)
            {
                atoms[i].Display();
            }
        }
    }
}