using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lumi.Models
{
    public interface IEntity
    {
        public int EntityId { get; }
        public IHealth Health { get; }
        public IAbility Ability { get; }
    }
}