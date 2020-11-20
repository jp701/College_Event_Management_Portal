using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public interface IEventRepository
    {
        ClgEvent GetEvent(int Id);

        IEnumerable<ClgEvent> GetAllEvents();

        IEnumerable<ClgEvent> GetDoneEvents();

        ClgEvent AddEvent(ClgEvent evnt);

        ClgEvent UpdateEvent(ClgEvent evnt);

        ClgEvent DeleteEvent(int Id);

    }
}
