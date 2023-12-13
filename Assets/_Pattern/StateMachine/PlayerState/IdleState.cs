using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character.Animation;
using UnityEngine;

public class IdleState : IState<Player>
{
    public void OnEnter(Player t)
    { 
        t.isMoving = false;
        t.ChangeAnim(AnimType.IDLE);
    }

    public void OnExecute(Player t)
    {
        if (t.checkMove())
        {
            t.currentState.ChangeState(t.RunState);
            return;
        }
        if (t.isAttack)
        {
            t.currentState.ChangeState(t.AttackState);
        }
    }

    public void OnExit(Player t)
    {
        
    }
}
