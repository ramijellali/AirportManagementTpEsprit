using System;
using System.Collections.Generic;

namespace AM.applicationcore.Interfaces
{
    public interface IServiceFlight
    {
        List<DateTime> GetFlightDates(string destination);
    }
}
