namespace Lumi.Models
{
    public class Entity : IEntity
    {
        public int EntityId { get; }
        public IHealth Health { get; }
        public IAbility Ability { get; }
        
        public Entity(int entityId, IHealth health, IAbility ability)
        {
            EntityId = entityId;
            Health = health;
            Ability = ability;
        }
    }
}