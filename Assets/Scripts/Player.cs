using UnityEngine;

public class Player : MonoBehaviour 
{
    [SerializeField] int playerLife;
    [SerializeField] int playerDamagePower;
    LifeSystem lifeSystem = new LifeSystem();

    private void Start() 
    {
        lifeSystem.SetPlayerLife(playerLife);
        lifeSystem.SetDamagePlayer(playerDamagePower);

    }
    private void Update() 
    {
        playerLife=lifeSystem.GetPlayerLife();
    }

    
    
    
}