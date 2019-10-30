
namespace ParseTo.Objects
{
    internal sealed class String : IParseTo<string>
    {
        public string Parse(object i)
        {
            return i == null ? null : System.Convert.ToString(i);
        }

        public string GetDefault()
        {
            return "";
        }
    }
}
