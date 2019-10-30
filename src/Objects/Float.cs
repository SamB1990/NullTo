
namespace ParseTo.Objects
{
    public class Float : IParseTo<float>
    {
        public float Parse(object i)
        {
            return (float) i;
        }

        public float GetDefault()
        {
            return 0;
        }
    }
}
