using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    [SerializeField] int AttackDamage;
    [SerializeField] GameObject target;
    [SerializeField] GameObject player;
    [SerializeField] AudioClip clip;
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
        if (other.transform.CompareTag(target.tag))
        {
            other.gameObject.GetComponent<StatManager>().ReduceHP(AttackDamage);
            source.clip = clip;
            source.Play();

        }
        if (other.transform.CompareTag(player.tag))
        {
            other.gameObject.GetComponent<Player>().Hurt(AttackDamage);
        }
    }
}
