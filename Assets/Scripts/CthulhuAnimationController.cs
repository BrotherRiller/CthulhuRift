using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CthulhuAnimationController : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk()
    {
        anim.SetTrigger("Walk");
        
    }

    public void Attack()
    {
        anim.SetTrigger("Attack");
        
    }

    public void Scream()
    {
        anim.SetTrigger("Scream");
       
    }

    public void Idle()
    {
        anim.SetTrigger("Idle");
    }
    public void Die()
    {
        anim.SetTrigger("Die");
        
    }
    public void Death()
    {
        anim.SetTrigger("Death");
    }
}
