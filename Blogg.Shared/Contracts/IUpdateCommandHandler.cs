namespace Blogg.Shared.Contracts;

public interface IUpdateCommandHandler<in TEntity> where TEntity :class
{
    public void Handle(TEntity entity);
}