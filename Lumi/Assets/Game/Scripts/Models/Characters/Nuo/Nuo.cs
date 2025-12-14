using Lumi;

namespace Lumi.Models
{
    public sealed class Nuo : Entity
    {
        public Nuo(int entityId, IHealth health, IAbility ability) : base(entityId, health, ability)
        {
        }
    }
}