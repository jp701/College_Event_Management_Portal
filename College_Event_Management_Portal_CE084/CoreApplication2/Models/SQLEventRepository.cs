using CoreApplication2.Data;
using System.Collections.Generic;
using System.Linq;

namespace CoreApplication2.Models
{
    public class SQLEventRepository: IEventRepository
    {
        private readonly ApplicationDbContext context;

        public SQLEventRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        ClgEvent IEventRepository.GetEvent(int Id)
        {
            return context.ClgEvents.Find(Id);
        }

        IEnumerable<ClgEvent> IEventRepository.GetAllEvents()
        {
            return context.ClgEvents;
        }

        IEnumerable<ClgEvent> IEventRepository.GetDoneEvents()
        {
            return context.ClgEvents.Where(e => e.Status!=0);
        }

        ClgEvent IEventRepository.AddEvent(ClgEvent evnt)
        {
            context.ClgEvents.Add(evnt);
            context.SaveChanges();
            return evnt;
        }

        ClgEvent IEventRepository.UpdateEvent(ClgEvent modifiedEvent)
        {
            var evnt = context.ClgEvents.Attach(modifiedEvent);
            evnt.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return modifiedEvent;
        }

        ClgEvent IEventRepository.DeleteEvent(int Id)
        {
            ClgEvent evnt = context.ClgEvents.Find(Id);
            if (evnt != null)
            {
                context.ClgEvents.Remove(evnt);
                context.SaveChanges();
            }
            return evnt;
        }

    }
}
