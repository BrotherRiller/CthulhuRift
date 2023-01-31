using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    CthulhuAnimationController anim;
    private Transform movePositionTransform;
    

    public enum FightingState
    {
        walk,
        attack,
        die,
        win,
        death
    }

    FightingState currentState;

    private NavMeshAgent agent;
    private StatManager enemyHP;
    private int HP;


    private void Awake()
    {
        anim = GetComponent<CthulhuAnimationController>();
        agent = GetComponent<NavMeshAgent>();
        currentState = FightingState.walk;
        enemyHP = GetComponent<StatManager>();

        movePositionTransform = GameObject.FindWithTag("Player").transform;
        

    }

    void Update()
    {
        HP = enemyHP.CheckHP();
        Debug.Log(HP);
        if(HP <= 0)
        {
            currentState = FightingState.die;
            
        }
        Debug.Log(currentState);
        switch (currentState)
        {
            case FightingState.walk:
                anim.Walk();
                agent.SetDestination(movePositionTransform.position);
                currentState = FightingState.attack;
                break;
            case FightingState.attack:
                if (Vector3.Distance(this.transform.position, movePositionTransform.position) < agent.stoppingDistance)
                {
                    anim.Attack();
                    agent.isStopped = true;
                    Debug.Log(agent.stoppingDistance);
                }
                else
                {
                    agent.isStopped = false;
                    currentState = FightingState.walk;
                }
                break;
            case FightingState.die:
                anim.Die();
                currentState = FightingState.death;
                break;
            case FightingState.win:
                anim.Idle();
                break;
            case FightingState.death:
                anim.Death();
                break;
            default:
                anim.Idle();
                break;
        }
    }
}
