namespace Lumi.Models
{
    public sealed class Health : IHealth
    {
        public bool IsAlive => CurrentHealth > 0;
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public void Initialize(int maxHealth)
        {
            MaxHealth = maxHealth < 1 ? 1 : maxHealth;
            CurrentHealth = MaxHealth;
        }

        public void TakeDamage(int damage)
        {
            if (!IsAlive) 
                return;
            
            if (damage <= 0) 
                return;

            CurrentHealth -= damage;
            
            if (CurrentHealth < 0) 
                CurrentHealth = 0;
        }
    }
}