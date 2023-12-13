using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character.Animation;
using UnityEngine;

public class EIdleState : IState<Enemy>
{
    public void OnEnter(Enemy t)
    {
        t.ChangeAnim(AnimType.IDLE);
    }

    public void OnExecute(Enemy t)
    {
        
    }

    public void OnExit(Enemy t)
    {
        
    }
}
