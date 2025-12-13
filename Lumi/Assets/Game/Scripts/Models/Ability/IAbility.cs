using UnityEngine;

namespace Lumi.Models
{
    public interface IAbility
    {
        public AbilityType AbilityType { get; }
        void Use(AbilityContext context);
    }
    
    public readonly struct AbilityContext
    {
        public readonly Transform Owner;
        public readonly Rigidbody2D Rb;

        public AbilityContext(Transform owner, Rigidbody2D rb)
        {
            Owner = owner;
            Rb = rb;
        }
    }
}