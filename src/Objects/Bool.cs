using System;

namespace ParseTo.Objects
{
    public class Bool : IParseTo<bool>, IParseTo<bool?>
    {

        bool IParseTo<bool>.Parse(object i)
        {
            switch (i)
            {
                case string _:
                    return bool.Parse(i.ToString());
                case int _:
                case Int16 _:
                case Int64 _:
                    return Convert.ToBoolean(i);
                default:
                    return (bool)i;
            }
            
        }

        bool IParseTo<bool>.GetDefault()
        {
            return false;
        }


        bool? IParseTo<bool?>.Parse(object i)
        {
            switch (i)
            {
                case string _:
                    return bool.Parse(i.ToString());
                case int _:
                case Int16 _:
                case Int64 _:
                    return Convert.ToBoolean(i);
                default:
                    return (bool)i;
            }
        }

        bool? IParseTo<bool?>.GetDefault()
        {
            return null;
        }
    }
}
