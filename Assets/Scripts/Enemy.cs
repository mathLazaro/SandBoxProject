using UnityEngine;

public interface IEnemy
{
    public void Set();
    public void EnemyGiveDamage(int damageGiven);
    public void EnemyTakeDamage(int damageTaken);
    public void UpdateLife();
    public int GetLife();
}
