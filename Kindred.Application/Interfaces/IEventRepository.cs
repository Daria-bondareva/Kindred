using Kindred.Domain.Entities;

namespace Kindred.Application.Interfaces
{
    public interface IEventRepository
    {
        Task AddAsync(Event _event);
        Task <List<Event>> GetAllAsync();
        Task <Event?> GetByIdAsync(int id);
        Task UpdateAsync(Event _event);
        Task DeleteByIdAsync(int id);
    }
}
