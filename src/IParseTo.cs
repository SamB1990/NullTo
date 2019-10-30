
using System;

namespace ParseTo
{
    internal interface IParseTo<out T>
    {
        T Parse(object i);

        T GetDefault();
    }
}
