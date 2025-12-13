using Lumi.Models;
using UnityEngine;
using Zenject;

namespace Lumi.Controllers
{
    public sealed class PlayerController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float moveSpeed = 6f;
        [SerializeField] private float jumpForce = 8f;

        [Header("Ground")]
        [SerializeField] private Transform groundCheck;
        [SerializeField] private LayerMask groundMask;

        private IPlayerInput _input;
        private Movement _movement;
        
        [Inject]
        public void Construct(IPlayerInput input)
        {
            _input = input;
        }
        
        private void Awake()
        {
            var rb = GetComponent<Rigidbody2D>();
            _movement = new Movement(rb, groundCheck, groundMask, moveSpeed, jumpForce);
        }
        
        private void Update()
        {
            var move = _input.ReadMove();
            _movement.SetInput(move);

            if (_input.ReadAbility())
            {
                // Ability.Use(...)
            }
        }
        
        private void FixedUpdate()
        {
            _movement.FixedTick();
        }
    }
}