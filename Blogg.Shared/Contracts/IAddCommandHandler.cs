namespace Blogg.Shared.Contracts;

public interface IAddCommandHandler<in TEntity> where TEntity :class
{
    public void Handle(TEntity entity);
}