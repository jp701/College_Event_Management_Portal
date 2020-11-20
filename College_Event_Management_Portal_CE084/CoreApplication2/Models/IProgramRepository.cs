using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public interface IProgramRepository
    {
        EventProgram GetProgram(int Id);

        IEnumerable<EventProgram> GetProgramsWithEventId(int EId);

        IEnumerable<EventProgram> GetAllPrograms();

        EventProgram AddProgram(EventProgram program);

        EventProgram UpdateProgram(EventProgram program);

        EventProgram DeleteProgram(int Id);

        IEnumerable<ClgEvent> GetAllEvents();
    }
}
