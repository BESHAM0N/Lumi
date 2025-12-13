using UnityEngine;

namespace Lumi.Models
{
    public interface IPlayerInput
    {
        public Vector2 ReadMove();
        public bool ReadAbility();
    }
}