using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character.Animation;
using UnityEngine;

public class RunState : IState<Player>
{
    public void OnEnter(Player t)
    {
        t.ChangeAnim(AnimType.RUN);
        t.isMoving = true;
    }

    public void OnExecute(Player t)
    {
        t.Move();
        if (!t.checkMove())
        {
            t.currentState.ChangeState(t.IdleState);
        }
    }

    public void OnExit(Player t)
    {
        t.isMoving = false;
    }
}
