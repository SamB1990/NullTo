using System;

namespace ParseTo.Objects
{
    public class DateTime : IParseTo<System.DateTime>, IParseTo<System.DateTime?>
    {
        System.DateTime IParseTo<System.DateTime>.Parse(object i)
        {
            if (i is string)
                return Convert.ToDateTime(i);
            return (System.DateTime)i;
        
        }

        System.DateTime IParseTo<System.DateTime>.GetDefault()
        {
            return System.DateTime.MinValue;
        }

        System.DateTime? IParseTo<System.DateTime?>.Parse(object i)
        {
            if (i is string)
                return Convert.ToDateTime(i);
            return (System.DateTime?)i;
        }

        System.DateTime? IParseTo<System.DateTime?>.GetDefault()
        {
            return null;
        }
    }
}
