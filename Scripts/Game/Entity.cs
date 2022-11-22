namespace Athormito.Scripts.Game
{
    [System.Serializable]
    public class Entity : Engine.EngObject
    {
        public int health;
        public Container container;

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
