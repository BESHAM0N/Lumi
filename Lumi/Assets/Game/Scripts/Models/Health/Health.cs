namespace Game.Scripts.Models.Health
{
    public class Health : IHealth
    {
        public bool IsAlive { get; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        
        public void TakeDamage(int damage)
        {
            
        }
    }
}