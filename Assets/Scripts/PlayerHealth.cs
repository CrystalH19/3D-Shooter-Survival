using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public TMP_Text number;
    public int playerhealth = 25;
    public int totalhealth = 25;

    void Start()
    {
        number.text = playerhealth.ToString();
    }

    public void PlayerDamage(int amount)
    {
        playerhealth -= amount;
        number.text = playerhealth.ToString();
        if (playerhealth <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

    public void resetHealth()
    {
        playerhealth = totalhealth;
    }
}
