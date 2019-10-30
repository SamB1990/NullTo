
namespace ParseTo.Objects
{
    internal sealed class Guid : IParseTo<System.Guid>
    {
        public System.Guid Parse(object i)
        {
            var guidString = System.Convert.ToString(i);

            return System.Guid.Parse(guidString);
        }

        public System.Guid GetDefault()
        {
            return System.Guid.Empty;
        }
    }
}
