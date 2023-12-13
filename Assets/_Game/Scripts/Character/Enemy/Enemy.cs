using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character.Animation;


public class Enemy : Character
{
    [SerializeField] private UnityEngine.AI.NavMeshAgent agent;
    
    public StateMachine<Enemy> currentState;

    #region State
    public EIdleState EIdleState { get; private set; }
    public EPatrolState EPatrolState { get; private set; }
    public EDeadState EDeadState { get; private set; }
    #endregion
    
    private void Awake()
    {
        base.Awake();
        OnInit();
    }

    private void OnInit()
    {
        base.OnInit();
        InitState();
    }

    private void Update()
    {
        
    }

    private void InitState()
    {
        EIdleState = new EIdleState();
        EPatrolState = new EPatrolState();
        EDeadState = new EDeadState();
        
        currentState = new StateMachine<Enemy>();
        currentState.SetCharacter(this);
        currentState.ChangeState(EIdleState);
    }

    public void MoveTo(Vector3 point)
    {
        agent.enabled = true;
        agent.SetDestination(point);
        
    }
} 
