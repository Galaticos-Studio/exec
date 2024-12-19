// IEnemy.cs
public interface IEnemy
{
    float Hp { get; set; }
    float AttackPower { get; set; }
    float MovementSpeed { get; set; }
    bool IsDead { get; set; }
    void TakeDamage(int damage);
    void Attack();
}