
namespace lab04
{
    public class Faculty:Employee
    {
        public string OfficeHour { get; set; }
        public int Rank { get; set; }
        public override double CalculateBonus()
            {
                return 1000 + 0.05 * Salazy;
            }
        public override int CalculateVacation()
        {
            if (DateHired > 3 && Rank == 1)
            {
                return 6;
            }
            else if(DateHired > 3 && Rank != 1)
            {
                return 5;
            }
            else
            {
                return 4;
            }
        }
    }
}