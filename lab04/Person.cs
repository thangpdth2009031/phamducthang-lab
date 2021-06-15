namespace lab04
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public override string ToString()
            {
                return $"Name : {Name},  Email : {Email},  Phone : {Phone}";
            }
    }
}