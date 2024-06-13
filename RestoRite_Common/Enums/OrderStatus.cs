using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoRite_Common.Enums
{
    public enum OrderStatus : byte
    {
        Pending = 1,
        Confirmed = 2,
        Preparing = 3,
        Completed = 4,
        Cancelled = 5
    }
}