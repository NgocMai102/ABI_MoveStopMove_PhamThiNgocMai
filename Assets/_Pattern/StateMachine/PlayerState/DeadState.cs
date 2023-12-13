using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character.Animation;
using UnityEngine;

public class DeadState : IState<Player>
{
    public void OnEnter(Player t)
    {
        t.isMoving = false;
        t.ChangeAnim(AnimType.DEAD);
    }

    public void OnExecute(Player t)
    {
        
    }

    public void OnExit(Player t)
    {
        
    }
}
