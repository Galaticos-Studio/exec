// Goblin.cs
using UnityEngine;

public class Goblin : Enemy
{
    protected override void Start()
    {
        Debug.Log("GOBLIN START 1");
        base.Start();
        Debug.Log("GOBLIN START 2");
        Hp = 50; // Goblins are weaker
        AttackPower = 5; // Goblins deal less damage
        Debug.Log("A Goblin has spawned!");
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Goblin Attacks");
    }

    protected override void Die()
    {
        base.Die();
    }

    public override void OnPlayerInRange(GameObject player)
    {
        Debug.Log("Goblin has Player in range");
        Attack();
    }
}
