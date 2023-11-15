namespace AlpineScheduler.Server.Services
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> GetAll();
        public TEntity GetById(object Id);
        public void AddEntity(TEntity entity);
        public void UpdateEntity(TEntity current , TEntity update);
        public void DeleteEntity(TEntity entity);
    }
}
