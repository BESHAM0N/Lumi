
namespace Lumi.Models
{
    public sealed class Lumi : Entity
    {
        public Lumi(int entityId, IHealth health, IAbility ability) : base(entityId, health, ability)
        {
        }
    }
}