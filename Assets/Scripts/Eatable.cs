using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatable : MonoBehaviour
{
    [SerializeField] float healDegree;
    Player player;

    private void Start()
    {
        
        player = FindObjectOfType<Player>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            player.Heal(healDegree);
            Destroy(this.gameObject);
        }
    }
}
