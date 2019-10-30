
namespace ParseTo.Extensions
{
    public static class ParseToExtensions
    {
        public static Handler handler { get; set; } = new DefaultParseToHandler();
        
        /// <summary>
        /// Parses an object to either the type of T or a default
        /// </summary>
        /// <typeparam name="T">The type you wish to cast to</typeparam>
        /// <param name="i">The object you wish to cast</param>
        /// <param name="defaultValue">Custom default to override the base default</param>
        /// <returns></returns>
        public static T ParseTo<T>(this object i, T defaultValue = default)
        {
            return handler.Handle<T>(i, defaultValue);
        }
    }
}
