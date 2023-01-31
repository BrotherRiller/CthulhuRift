using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    Eatable eatable;
    Player player;
    private float healDegree;
    private void Start()
    {
        eatable = FindObjectOfType<Eatable>();
        player = FindObjectOfType<Player>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Eatable"))
        {
            Debug.Log(healDegree);
            player.Heal(healDegree);
            Destroy(other.gameObject);
        }
    }
}
