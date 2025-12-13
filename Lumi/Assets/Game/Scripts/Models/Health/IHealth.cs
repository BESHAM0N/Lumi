namespace Lumi.Models
{
    public interface IHealth
    {
        public bool IsAlive { get; }
        public int MaxHealth { get; }
        public int CurrentHealth { get;}
        
        void Initialize(int maxHealth);
        public void TakeDamage(int damage);
    }
}