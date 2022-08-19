namespace Blogg.Shared.Contracts;

public interface IGetAllCommandHandler<TEntity> where TEntity :class
{
    public IEnumerable<TEntity> Handle();
}