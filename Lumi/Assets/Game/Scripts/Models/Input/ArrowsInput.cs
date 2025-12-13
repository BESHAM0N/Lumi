using UnityEngine;

namespace Lumi.Models
{
    public sealed class ArrowsInput : IPlayerInput
    {
        public Vector2 ReadMove()
        {
            float x = (Input.GetKey(KeyCode.RightArrow) ? 1 : 0) + (Input.GetKey(KeyCode.LeftArrow) ? -1 : 0);
            float y = Input.GetKey(KeyCode.UpArrow) ? 1 : 0;
            return new Vector2(x, y);
        }

        public bool ReadAbility() => Input.GetKeyDown(KeyCode.DownArrow);
    }
}