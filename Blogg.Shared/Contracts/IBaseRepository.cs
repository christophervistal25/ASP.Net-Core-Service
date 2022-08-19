namespace Blogg.Shared.Contracts;

public interface IBaseRepository<TEntity> where TEntity : class
{
    public IEnumerable<TEntity> Get();

    public TEntity Find(int id);

    public void Create(TEntity entity);

    public void Update(TEntity entity);
}