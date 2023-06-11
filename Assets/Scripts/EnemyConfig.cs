using UnityEngine;

public class EnemyConfig : MonoBehaviour, IEnemy
{
    [SerializeField] int enemyLife;
    [SerializeField] int enemyDamagePower;
    
    static int lifeStatic;

    LifeSystem lifeSystem = new LifeSystem();
     public void Set()
    {
        lifeSystem.SetLife(enemyLife);
        lifeStatic=enemyLife;
    }
    public void EnemyTakeDamage(int damageTaken)
    {
        if(Input.GetKeyDown(KeyCode.C)) lifeSystem.DecraseLife(damageTaken);
    }
    public void EnemyGiveDamage(int damagePower)
    {
        if(Input.GetKeyDown(KeyCode.A)) lifeSystem.DecrasePlayerLife(damagePower);
    }
    public void UpdateLife()
    {
        lifeStatic=enemyLife=lifeSystem.GetLife();
    }
    public int GetLife() {return lifeStatic;}

    private void Start() 
    {
        Set();
    }
    private void Update() 
    {
        EnemyGiveDamage(enemyDamagePower);
        EnemyTakeDamage(lifeSystem.GetPlayerDamagePower());
        UpdateLife();
    }
   
}