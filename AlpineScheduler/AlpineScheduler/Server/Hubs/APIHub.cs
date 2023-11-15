using Microsoft.AspNetCore.SignalR;
using AlpineScheduler.Server.Services;
using AlpineScheduler.Shared.Models;


namespace AlpineScheduler.Server.Hubs
{
    public class APIHub:Hub
    {
        IJobRepository jobRepository;

        public APIHub(IJobRepository repo)
        {
            jobRepository = repo;
        }
        public List<Job> LoadJobs(int range)
        {
            List<Job> jobs = jobRepository.GetAll().ToList();

            //Job x = new Job(new DateTime(2022, 7, 15), 3, "Z", "Brown", 6);
            //Job A = new Job(DateTime.Now, 5, "A", "Brown", 6);
            //Job B = new Job(DateTime.Now.AddDays(1), 3, "B", "Green", 5);
            //Job C = new Job(DateTime.Now.AddDays(1), 8, "C", "Orange", 2);
            //Job D = new Job(DateTime.Now.AddDays(2), 17, "D", "Pink", 5);
            //Job[] result = { x, A, B, C, D };
            return jobs;
        }

        public void AddJob(Job job)
        {
            jobRepository.AddEntity(job);
        }

        public void EditJob(Job current, Job update)
        {
            update.Id = current.Id;
            jobRepository.UpdateEntity(current, update);
        }

        public void DeleteJob(Job job)
        {
            jobRepository.DeleteEntity(job);
        }
    }
}
