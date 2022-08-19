namespace Blogg.Shared.Contracts;

public interface IBaseMapper<TEntity, Entity> where TEntity : class where Entity :class
{
    public Entity TransformToEntity(TEntity tEntity);
    public TEntity TransformToPostTransport(Entity entity);
    public IEnumerable<TEntity> TransformToListOfTransports(List<Entity> entity);
}