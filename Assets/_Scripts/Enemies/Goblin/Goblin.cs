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
        Debug.Log("The Goblin swings its rusty dagger!");
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log("The Goblin screams 'Arghhh!' as it falls.");
    }

    public override void OnPlayerInRange(GameObject player)
    {
        Debug.Log("The Goblin shouts and rushes toward the player!");
        Attack();
    }
}
