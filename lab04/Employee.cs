namespace lab04
{
    public abstract class Employee:Person
    {
        public string Department { get; set; }
        public int Salazy { get; set; }
        public int DateHired { get; set; }
        public abstract int CalculateVacation();
        public abstract double CalculateBonus();
    }
}