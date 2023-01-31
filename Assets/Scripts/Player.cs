using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    UI UI;
    [SerializeField] float updateHealthTime;
    [SerializeField] float health;

    // Start is called before the first frame update
    void Start()
    {
        UI = FindObjectOfType<UI>();
    }

    void Update()
    {
        if(health <= 0)
        {
            
        }
    }

    void SetHealth()
    {
        UI.SetRedScreen(false);
    }

    public void Hurt(float hurtDegree)
    {
        health -= hurtDegree;
        health = Mathf.Clamp(health, 0, 1);
        UI.SetRedScreen(true);
    }

    public void Heal(float healDegree)
    {
        health += healDegree;
        health = Mathf.Clamp(health, 0, 1);
        
    }
}
