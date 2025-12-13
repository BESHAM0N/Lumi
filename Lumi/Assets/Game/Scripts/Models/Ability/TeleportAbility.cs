using UnityEngine;

namespace Lumi.Models
{
    public sealed class TeleportAbility : IAbility
    {
        public AbilityType AbilityType => AbilityType.Teleport;
        private readonly float _distance;
        
        public TeleportAbility(float distance)
        {
            _distance = distance;
        }
        
        public void Use(AbilityContext context)
        {
            if (context.Owner == null) return;
            context.Owner.position += Vector3.right * _distance;
        }
    }
}