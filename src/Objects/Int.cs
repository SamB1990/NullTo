
namespace ParseTo.Objects
{
    internal sealed class Int : IParseTo<int>, IParseTo<int?>
    {
        int IParseTo<int>.Parse(object i)
        {
            return int.Parse(i.ToString());
        }

        int IParseTo<int>.GetDefault()
        {
            return 0;
        }

        int? IParseTo<int?>.Parse(object i)
        {
            if (i == null) return null;
            return int.Parse(i.ToString());
        }

        int? IParseTo<int?>.GetDefault()
        {
            return null;
        }
    }
}
