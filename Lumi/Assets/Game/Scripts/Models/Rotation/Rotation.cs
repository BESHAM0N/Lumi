using UnityEngine;

namespace Lumi.Models
{
    public sealed class Rotation
    {
        private readonly Transform _root;
        private float _lastDirection = 1f;

        public Rotation(Transform root)
        {
            _root = root;
        }

        public void Tick(float horizontalInput)
        {
            if (Mathf.Abs(horizontalInput) < 0.01f)
                return;

            _lastDirection = Mathf.Sign(horizontalInput);

            var scale = _root.localScale;
            scale.x = Mathf.Abs(scale.x) * _lastDirection;
            _root.localScale = scale;
        }
    }
}