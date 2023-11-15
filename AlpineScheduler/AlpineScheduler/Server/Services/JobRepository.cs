using AlpineScheduler.Server.Models;
using AlpineScheduler.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AlpineScheduler.Server.Services
{
    public class JobRepository : IJobRepository
    {
        
        ApplicationDbContext context;
        public DbSet<Job> jobs;
        
        public JobRepository(ApplicationDbContext context)
        {
           this.context = context;
            jobs = context.Jobs;
            
        }

        public void AddEntity(Job entity)
        {
            context.Jobs.Add(entity);
            context.SaveChanges();
        }

        public void DeleteEntity(Job entity)
        {
            context.Jobs.Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<Job> GetAll()
        {
            return jobs.OrderBy(s=>s.DateTime).AsQueryable();
        }

        public Job GetById(long Id)
        {
            return jobs.Find(Id);
        }

        public Job GetById(object Id)
        {
            return context.Jobs.Find(Id);
        }

    
        public void UpdateEntity(Job current, Job update)
        {
            Job job = context.Jobs.Find(current.Id);
            job.Duration = update.Duration;
            job.Name = update.Name;
            job.StartTime = update.StartTime;
            job.DateTime = update.DateTime; 
            job.Team = update.Team; 
            context.SaveChanges();
        }
    }
}
