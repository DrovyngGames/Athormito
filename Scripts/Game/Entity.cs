namespace Athormito.Scripts.Game
{
    [System.Serializable]
    public class Entity : Engine.EngObject
    {
        public int maxHealth;
        public int health;
        public Container container;
        public override void Create()
        {
            health = maxHealth;
        }
        public virtual void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0) Die();
        }
        public virtual void Die()
        {

        }
    }
}
