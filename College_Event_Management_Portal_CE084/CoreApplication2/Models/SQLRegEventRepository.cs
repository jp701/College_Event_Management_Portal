using CoreApplication2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public class SQLRegEventRepository:IRegEventRepository
    {
        private readonly ApplicationDbContext context;

        public SQLRegEventRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        RegEvent IRegEventRepository.GetRegEvent(int Id)
        {
            return context.RegEvents.Include(r => r.Event).FirstOrDefault(r => r.Id == Id);
        }

        IEnumerable<RegEvent> IRegEventRepository.GetAllRegEvents()
        {
            return context.RegEvents.Include(r => r.Event).Include(r => r.User);
        }

        IEnumerable<RegEvent> IRegEventRepository.GetRegEventsWithUserId(string Id)
        {
            return context.RegEvents.Include(r => r.Event).Where(r => r.UserId == Id);
        }

        RegEvent IRegEventRepository.AddRegEvent(RegEvent regEvent)
        {
            context.RegEvents.Add(regEvent);
            context.SaveChanges();
            return regEvent;
        }

        RegEvent IRegEventRepository.DeleteRegEvent(int Id)
        {
            RegEvent regEvent = context.RegEvents.Find(Id);
            if (regEvent != null)
            {
                context.RegEvents.Remove(regEvent);
                context.SaveChanges();
            }
            return regEvent;
        }
    }
}
