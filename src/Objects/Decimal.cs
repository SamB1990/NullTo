
namespace ParseTo.Objects
{
    public class Decimal : IParseTo<decimal>
    {
        public decimal Parse(object i)
        {
            return decimal.Parse(i.ToString());
        }

        public decimal GetDefault()
        {
            return 0;
        }
    }
}
