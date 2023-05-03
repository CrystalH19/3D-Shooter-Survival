using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int health = 6;
    public int maxHealth = 6;
    public bool destroyWhenDead = true;


    public void Damage(int amount)
    {
        health -= amount;
        if (health <= 0 && destroyWhenDead)
        {
            Destroy(gameObject);
        }
    }

    

    public void resetHealth()
    {
        health = maxHealth;
    }

}
