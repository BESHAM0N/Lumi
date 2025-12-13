using UnityEngine;

namespace Lumi.Models
{
    public sealed class WasdInput : IPlayerInput
    {
        public Vector2 ReadMove()
        {
            float x = (Input.GetKey(KeyCode.D) ? 1 : 0) + (Input.GetKey(KeyCode.A) ? -1 : 0);
            float y = Input.GetKey(KeyCode.W) ? 1 : 0;
            return new Vector2(x, y);
        }

        public bool ReadAbility() => Input.GetKeyDown(KeyCode.S);
    }
}