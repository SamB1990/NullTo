
namespace ParseTo.Extensions
{
    public static class ParseToExtensions
    {
        private static Handler handler { get; set; } = new DefaultParseToHandler();
        
        public static T ParseTo<T>(this object i, T defaultValue = default)
        {
            return handler.Handle<T>(i, defaultValue);
        }
    }
}
