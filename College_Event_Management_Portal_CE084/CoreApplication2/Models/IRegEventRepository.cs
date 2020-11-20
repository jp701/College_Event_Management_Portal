using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public interface IRegEventRepository
    {
        RegEvent GetRegEvent(int Id);

        IEnumerable<RegEvent> GetAllRegEvents();

        IEnumerable<RegEvent> GetRegEventsWithUserId(string Id);

        RegEvent AddRegEvent(RegEvent regEvent);

        RegEvent DeleteRegEvent(int Id);
    }
}
