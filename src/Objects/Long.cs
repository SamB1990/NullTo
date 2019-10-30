
namespace ParseTo.Objects
{
    public class Long : IParseTo<long>
    {
        public long Parse(object i)
        {
            return long.Parse(i.ToString());
        }

        public long GetDefault()
        {
            return 0;
        }
    }
}
