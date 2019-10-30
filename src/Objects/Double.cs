
namespace ParseTo.Objects
{
    public class Double : IParseTo<double>
    {
        public double Parse(object i)
        {
            return double.Parse(i.ToString());
        }

        public double GetDefault()
        {
            return 0;
        }
    }
}
