// Enemy.cs
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IEnemy
{
    public float AttackPower { get; set; } = 10;
    public float MovementSpeed { get; set; } = 3.5f;
    public float Hp { get; set; } = 100;
    public bool IsDead { get; set; } = false;

    protected EnemyMovement movement;

    protected virtual void Start()
    {
        Debug.Log("BASE START");
        // Attach or get the EnemyMovement script
        movement = GetComponent<EnemyMovement>();
        if (movement == null)
        {
            movement = gameObject.AddComponent<EnemyMovement>();
        }
    }

    public virtual void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log($"{gameObject.name} took {damage} damage. Remaining HP: {Hp}");

        if (Hp <= 0)
        {
            Die();
        }
    }

    public virtual void Attack()
    {
        Debug.Log($"{gameObject.name} attacks with {AttackPower} power!");
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} Died");
        IsDead = true;
        Destroy(gameObject);
    }

    public virtual void OnPlayerInRange(GameObject player)
    {
        // Default behavior when the player is detected
        Debug.Log($"{gameObject.name} detected the player! Default behavior triggered.");
    }

}
