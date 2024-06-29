using Kindred.Application.Interfaces;
using Kindred.Domain.Entities;
using Kindred.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kindred.Infrastructure.Repositories
{
    public class EventRepository: IEventRepository
    {
        private readonly KindredDbContext context;
        public EventRepository(IDbContextFactory<KindredDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Event _event)
        {
            context.Events.Add(_event);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var event_ = await GetByIdAsync(id);
            if (event_ != null)
            {
                context.Events.Remove(event_);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Event>> GetAllAsync()
        {
            var events = await context.Events.ToListAsync();
            return events;
        }

        public async Task<Event?> GetByIdAsync(int id)
        {
            var event_ = await context.Events.FirstOrDefaultAsync(e => e.Id == id);
            return event_;
        }

        public async Task UpdateAsync(Event _event)
        {
            context.Entry(_event).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
