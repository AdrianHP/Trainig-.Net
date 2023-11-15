
using AlpineScheduler.Shared.Models;

namespace AlpineScheduler.Server.Services
{
    public interface IJobRepository : IRepository<Job>
    {
        public new IQueryable<Job> GetAll();
        public Job GetById(long id);
        public new void AddEntity(Job entity);
        public new void UpdateEntity(Job current,Job update);
        public new void DeleteEntity(Job entity);
    }
}
