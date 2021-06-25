namespace Generics
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Dob: {Dob}";
        }
        public abstract void Speak();
    }
}