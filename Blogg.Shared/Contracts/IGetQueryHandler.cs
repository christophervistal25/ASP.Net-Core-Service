namespace Blogg.Shared.Contracts;

public interface IGetQueryHandler<TEntity> where TEntity :class
{
    public TEntity Handle(int id);
}