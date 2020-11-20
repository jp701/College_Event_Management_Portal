using CoreApplication2.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreApplication2.Models
{
    public class SQLProgramRepository:IProgramRepository
    {
        private readonly ApplicationDbContext context;

        public SQLProgramRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        EventProgram IProgramRepository.GetProgram(int Id)
        {
            return context.EventPrograms.Include(p => p.ClgEvent)
                .FirstOrDefault(p => p.Id == Id);
        }

        IEnumerable<EventProgram> IProgramRepository.GetProgramsWithEventId(int Id)
        {
            return context.EventPrograms.Include(p => p.ClgEvent).Where(p => p.EventId== Id);
        }

        IEnumerable<EventProgram> IProgramRepository.GetAllPrograms()
        {
            return context.EventPrograms.Include(p => p.ClgEvent);
        }

        EventProgram IProgramRepository.AddProgram(EventProgram program)
        {
            context.EventPrograms.Add(program);
            context.SaveChanges();
            return program;
        }

        EventProgram IProgramRepository.UpdateProgram(EventProgram updatedProgram)
        {
            var prog = context.EventPrograms.Attach(updatedProgram);
            prog.State = EntityState.Modified;
            context.SaveChanges();
            return updatedProgram;
        }

        EventProgram IProgramRepository.DeleteProgram(int Id)
        {
            EventProgram prog = context.EventPrograms.Find(Id);
            if (prog != null)
            {
                context.EventPrograms.Remove(prog);
                context.SaveChanges();
            }
            return prog;
        }

        IEnumerable<ClgEvent> IProgramRepository.GetAllEvents()
        {
            return context.ClgEvents;
        }
    }
}
