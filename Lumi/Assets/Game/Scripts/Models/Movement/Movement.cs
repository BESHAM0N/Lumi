using UnityEngine;

namespace Lumi.Models
{
    public sealed class Movement
    {
        private readonly Rigidbody2D _rb;
        private readonly Transform _groundCheck;
        private readonly LayerMask _groundMask;
        
        private readonly float _moveSpeed;
        private readonly float _jumpForce;
        private readonly float _groundCheckRadius;
        
        private Vector2 _input;
        private bool _jumpPressed;
        
        public Movement(
            Rigidbody2D rb,
            Transform groundCheck,
            LayerMask groundMask,
            float moveSpeed,
            float jumpForce,
            float groundCheckRadius = 0.12f)
        {
            _rb = rb;
            _groundCheck = groundCheck;
            _groundMask = groundMask;
            _moveSpeed = moveSpeed;
            _jumpForce = jumpForce;
            _groundCheckRadius = groundCheckRadius;
        }
        
        public void SetInput(Vector2 input)
        {
            _input = input;
            if (input.y > 0f) 
                _jumpPressed = true;
        }
        
        public void FixedTick()
        {
            var v = _rb.velocity;
            v.x = _input.x * _moveSpeed;
            _rb.velocity = v;
         
            if (_jumpPressed && IsGrounded())
            {
                var vel = _rb.velocity;
                vel.y = 0f;
                _rb.velocity = vel;
                _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            }

            _jumpPressed = false;
        }
        
        private bool IsGrounded()
        {
            if (_groundCheck == null) 
                return true;
            
            return Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _groundMask) != null;
        }
    }
}